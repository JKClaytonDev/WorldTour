using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSwim : MonoBehaviour
{
    Vector3 lPP;
    GameObject player;
    Vector3 grav;
    public GameObject vol;
    bool lastIn;
    GameObject flashLight;
    // Start is called before the first frame update
    void OnEnable()
    {
        if (FindObjectOfType<flashLight>())
        {
            flashLight = FindObjectOfType<flashLight>().gameObject;
        }
        player = FindObjectOfType<Movement>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        vol.SetActive(false);
        if (player)
        {
            if (transform.position.y > player.transform.position.y)
            {
                if (!lastIn)
                    lPP = player.transform.position;
                lastIn = true;
                vol.SetActive(true);
                Physics.gravity = new Vector3();
                player.GetComponent<Rigidbody>().velocity = (75 * ((player.transform.forward * Input.GetAxis("Vertical")) + (player.transform.right * Input.GetAxis("Horizontal"))));
            }
            else
            {
                if (lastIn)
                {
                    player.GetComponent<Rigidbody>().velocity = new Vector3(0, 20, 0);
                    
                }
                lastIn = false;
                if (Physics.gravity != new Vector3())
                grav = Physics.gravity;
                Physics.gravity = grav;
            }
        }
        player.GetComponent<Movement>().inWater = lastIn;
        flashLight.SetActive(lastIn);
    }
}
