using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animTrigger : MonoBehaviour
{
    public Animator anim;
    public string AnimName;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Movement>())
        {
            anim.Play(AnimName);
            Destroy(gameObject);
        }
    }
}
