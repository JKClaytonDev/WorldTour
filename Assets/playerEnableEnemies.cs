using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerEnableEnemies : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject otherCollider;
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
        foreach (GameObject e in enemies)
            e.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Movement>())
        {
            if (otherCollider)
            {
                otherCollider.SetActive(false);
                foreach (GameObject e in otherCollider.GetComponent<removeEnemies>().list)
                    e.SetActive(true);
            }
            else {
                        foreach (GameObject e in enemies)
                            e.SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}
