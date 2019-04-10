using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureChanger : MonoBehaviour
{
    public GameObject layer1;
    public GameObject layer2;
    public GameObject layer3;
    public GameObject layer4;
    public GameObject layer5;
    public GameObject layer6;
    public GameObject layer7;

    public void L1()
    {
        layer1.SetActive(false);
        layer2.SetActive(true);
    }

    public void L2()
    {
        layer2.SetActive(false);
        layer3.SetActive(true);
    }
    public void L3()
    {
        layer3.SetActive(false);
        layer4.SetActive(true);
    }

    public void L4()
    {
        layer4.SetActive(false);
        layer5.SetActive(true);
    }

    public void L5()
    {
        layer5.SetActive(false);
        layer6.SetActive(true);
    }

    public void L6()
    {
        layer6.SetActive(false);
        layer7.SetActive(true);
    }

    public void L7()
    {
        layer7.SetActive(false);
        layer1.SetActive(true);
    }
}
