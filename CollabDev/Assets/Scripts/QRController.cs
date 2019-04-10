using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using ZXing;

public class QRController : MonoBehaviour
{
    private bool camAvailable;
    private WebCamTexture backCam;
    private Texture defaultBackground;
    private bool canScanQR = true;

    public RawImage background;
    public AspectRatioFitter fit;
    public int QRcount = 0;



    //To detect if there is a back camera
    private void Start()
    {
        defaultBackground = background.texture;
        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length == 0)
        {
            Debug.Log("No camera detected");
            camAvailable = false;
            return;
        }

        for(int i = 0; i < devices.Length; i++)
        {
            if (!devices[i].isFrontFacing)
            {
                backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
            }
        }

        if (backCam == null)
        {
            Debug.Log("Unable to find back camera");
            return;
        }

        backCam.Play();
        background.texture = backCam;

        camAvailable = true;

    }

    private void Update()
    {


        
        if (!camAvailable)
            return;

        float ratio = (float)backCam.width / (float)backCam.height;
        fit.aspectRatio = ratio;

        float scaleY = backCam.videoVerticallyMirrored ? -1f : 1f;
        background.rectTransform.localScale = new Vector3(1f, scaleY, 1f);

        if (!canScanQR) {
            return;
        }
        try
        {
            Debug.Log("Searching for QR");
            IBarcodeReader barcodeReader = new BarcodeReader();
            // decode the current frame
            var result = barcodeReader.Decode(backCam.GetPixels32(),
              backCam.width, backCam.height);
            if (result != null)
            {
                if(result.Text == "openDeck")
                {
                    SceneManager.LoadScene("openDeck");
                    QRcount++;
                }
                if (result.Text =="MI101A")
                {
                    SceneManager.LoadScene("MI101A");
                    QRcount++;
                }
                if (result.Text =="MI101B")
                {
                    SceneManager.LoadScene("MI101B");
                    QRcount++;

                }
                if (result.Text == "MI101C")
                {
                    SceneManager.LoadScene("MI101c");
                    QRcount++;
                }
                if (result.Text == "finalCode")
                {
                    SceneManager.LoadScene("finalPage");
                    QRcount++;
                }
                if (QRcount == 6)
                {
                    SceneManager.LoadScene("finalPage");
                }
                else
                {
                    Debug.Log("DECODED TEXT FROM QR: " + result.Text);
                }
                
            }
            StartCoroutine(SlowDown());
        }
        catch (Exception ex) { Debug.LogWarning(ex.Message); }

        //int orient = backCam.videoRotationAngle;
        //background.rectTransform.localEulerAngles = new Vector3(0, 0, );
    }

    
    //Delay on the scanner
    IEnumerator SlowDown()
    {
        canScanQR = false;
        yield return new WaitForSeconds(1);
        canScanQR = true;
    }
}


