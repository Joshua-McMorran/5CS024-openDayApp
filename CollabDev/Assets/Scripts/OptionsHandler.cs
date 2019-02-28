using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsHandler : MonoBehaviour
{
    public GameObject m_options;
    public GameObject m_main;

    bool m_isMainMenu = true;

    public void OnOptionsClicked()
    {
        m_isMainMenu = false;

        m_options.SetActive(true);
        m_main.SetActive(false);
    }

    public void OnMenuClicked()
    {
        m_isMainMenu = true;

        m_options.SetActive(false);
        m_main.SetActive(true);
    }
}
