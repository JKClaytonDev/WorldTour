using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeEnemies : MonoBehaviour
{
    public GameObject[] list;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().enabled = false;
        if (other.gameObject.GetComponent<enemyHealth>() || other.gameObject.GetComponent<AmmoCrate>() || other.gameObject.GetComponent<pickUpGun>() || other.gameObject.GetComponent<HealthCrate>() || other.gameObject.GetComponent<ParticleSystem>())
        {
            other.gameObject.SetActive(false);
            GameObject[] list2 = new GameObject[list.Length + 1];
            for (int i = 0; i<list.Length; i++)
            {
                list2[i] = list[i];
            }
            list2[list.Length] = other.gameObject;
            list = list2;
            
        }
    }
}
