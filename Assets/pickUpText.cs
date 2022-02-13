using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pickUpText : MonoBehaviour
{

    public float time = -50;
    public Canvas canv;

    // Update is called once per frame
    void Update()
    {
        canv.enabled = false;
        if (Time.realtimeSinceStartup < time + 3 && time < 10)
        canv.enabled = true;

    }
}
