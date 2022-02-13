using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathTracing : MonoBehaviour
{
    public GameObject g;
    // Start is called before the first frame update
    void Start()
    {
        if (QualitySettings.GetQualityLevel() == 4)
        {
            g.SetActive(true);
        }
    }

}
