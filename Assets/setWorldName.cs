using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class setWorldName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("WorldNameText", GetComponent<Text>().text);
        PlayerPrefs.SetString("PlayerWorld", SceneManager.GetActiveScene().name);
    }


}
