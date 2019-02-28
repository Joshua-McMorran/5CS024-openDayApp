using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public Image nav;
    public Image BOne;
    public Image BTwo;
    public void navStart()
    {
        if (!nav.gameObject.active)
        {
            nav.gameObject.SetActive(true);
            StartCoroutine(startSlide(0.1f));
        }
        else if (nav.gameObject.active)
        {
            StartCoroutine(startSlide(-0.1f));
        }
        
    }
    IEnumerator startSlide(float i)
    {
        yield return new WaitForSeconds(0.003f);
        nav.fillAmount = nav.fillAmount + i;
        BOne.fillAmount = BOne.fillAmount + i;
        BTwo.fillAmount = BTwo.fillAmount + i;
        if (nav.fillAmount<1 && nav.fillAmount>0)
        {
            StartCoroutine(startSlide(i));
        }    
        else if (nav.fillAmount == 0)
        {
            nav.gameObject.SetActive(false);
        }

        
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
