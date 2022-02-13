using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToPlayer : MonoBehaviour
{
    GameObject player;
    public Animator anim;
    public boxColliders col;
    public Movement mvmt;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetInteger("Running", Mathf.RoundToInt(Input.GetAxis("Vertical")));
        anim.SetInteger("JumpDir", Mathf.RoundToInt(Input.GetAxis("Horizontal")));
        anim.SetBool("Jumping", false);
        if (!col.OnGround && mvmt.jumps != 0)
        {
            anim.SetBool("Jumping", true);

        }
        if (!player)
            player = FindObjectOfType<Movement>().gameObject;
        transform.parent = player.transform;
        transform.localPosition = new Vector3(0, 0, 0);
        transform.position -= Vector3.up * 12;
        transform.parent = null;
        Vector3 rot = new Vector3();
        rot.y = player.transform.localEulerAngles.y;
        transform.localEulerAngles = rot;
        transform.position -= transform.forward;
    }
}
