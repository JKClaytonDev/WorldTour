using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateonstart : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("NoHUD") == 0)
        GetComponent<Canvas>().enabled = true;
    }

}
