using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videoPlayerWorld : MonoBehaviour
{
    public GameObject dDefault;
    bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        string namee = "Vid" + PlayerPrefs.GetString("PlayerWorld");
        foreach (videoWorld v in FindObjectsOfType<videoWorld>())
        {
            Debug.Log("FOUND " + v.gameObject.name + " NAME IS " + namee);
            if (v.name != namee)
                v.gameObject.SetActive(false);
            else
                active = true;
        }
        if (!PlayerPrefs.HasKey("PlayerWorld"))
        {
            PlayerPrefs.SetString("PlayerWorld", "WorldDef");
        }
        if (!active)
            dDefault.SetActive(true);
        
        
    }

    
}
