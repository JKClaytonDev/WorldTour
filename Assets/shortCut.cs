using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shortCut : MonoBehaviour
{
    private void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
    public GameObject obj;
    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Movement>())
        {
            obj.transform.parent = null;
            Destroy(gameObject);
            obj.SetActive(true);
            Destroy(obj, 3);
        }
    }
}
