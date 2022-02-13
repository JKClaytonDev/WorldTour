using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleImage : MonoBehaviour
{
    public float w;
    // Start is called before the first frame update
    void Start()
    {
        w = (Screen.width * 9) / (Screen.height * 16);
        Vector3 v = new Vector3(1, 1, 1);
        v.x = (Screen.width * 9) / (Screen.height * 16);
        GetComponent<RectTransform>().localScale = v;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
