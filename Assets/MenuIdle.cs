using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuIdle : MonoBehaviour
{
    Vector3 startPos;
    void Start()
    {
        Time.timeScale = 1;
        startPos = GetComponent<RectTransform>().localPosition;
    }
    void Update()
    {
        Vector3 pos = startPos;
        pos.x += Mathf.Sin(Time.realtimeSinceStartup) * 10;
        pos.y += Mathf.Cos(2+Time.realtimeSinceStartup) * 10;
        GetComponent<RectTransform>().localPosition = pos;
    }
}
