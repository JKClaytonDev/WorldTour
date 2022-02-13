using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleConsole : MonoBehaviour
{
    public GameObject essentials;
    public GameObject child;
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = null;
        essentials = FindObjectOfType<Essentials>().gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            child.SetActive(!child.activeInHierarchy);
            Time.timeScale = 1;

        }
        
        if (child.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }


    }
}
