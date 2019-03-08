using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSetUp : MonoBehaviour
{
    public GameObject UIBasePrefab;
    public GameObject BackGroudParent;
    void Start()
    {
        Instantiate(UIBasePrefab, BackGroudParent.transform);
    }
}
    