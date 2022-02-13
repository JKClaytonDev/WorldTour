    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lastLevel : MonoBehaviour
{
    public Text text2;
    // Update is called once per frame
    void Update()
    {
        if (!PlayerPrefs.HasKey("WorldNameText"))
            PlayerPrefs.SetString("WorldNameText", "Invasive Species");
        GetComponent<Text>().text = PlayerPrefs.GetString("Scene");
        text2.text = PlayerPrefs.GetString("WorldNameText");
    }
}
