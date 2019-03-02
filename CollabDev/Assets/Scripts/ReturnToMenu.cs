using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    public void goBack()
    {
        SceneManager.LoadScene("MenuPage");
    }

    public void QR()
    {
        SceneManager.LoadScene("QR-Reader");
    }
}
