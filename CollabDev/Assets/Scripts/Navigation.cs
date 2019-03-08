using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MenuPage");
    }

    public void QR()
    {
        SceneManager.LoadScene("QR-Reader");
    }

    public void AppPage()
    {
        SceneManager.LoadScene("AppPage");
    }

    public void Template()
    {
        SceneManager.LoadScene("Template");
    }

    public void QuitGame()
    {
        //Gives feedback for the method working
        Debug.Log("Exited app Sucessful");
        Application.Quit();
    }
}
