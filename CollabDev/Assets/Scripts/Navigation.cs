using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    //This is used so navigation can be accessed throughout the code.

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

    public void PDetails()
    {
        SceneManager.LoadScene("PersonalDetails");
    }

    public void Special()
    {
        SceneManager.LoadScene("CODEA");
    }

    public void OpenDeck()
    {
        SceneManager.LoadScene("openDeck");
    }

    public void MCI201a()
    {
        SceneManager.LoadScene("MI101A");
    }

    public void MCI204b()
    {
        SceneManager.LoadScene("MI101B");
    }

    public void MCI204c()
    {
        SceneManager.LoadScene("MI101C");
    }

    public void QuitGame()
    {
        //Gives feedback for the method working
        Debug.Log("Exited app Sucessful");
        Application.Quit();
    }
}
