using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableIncrement : MonoBehaviour
{
    public GameObject parent;
    // Update is called once per frame
    void Update()
    {
        if (Time.realtimeSinceStartup > 0.2f || Input.GetKey(KeyCode.F))
        {
            parent.SetActive(false);
            
            parent.SetActive(true);
            foreach(GameObject g in parent.transform)
            {
                g.transform.parent = null;
            }
            foreach (GameObject g in transform)
            {
                g.transform.parent = null;
            }
            gameObject.SetActive(false);
        }
    }
}
