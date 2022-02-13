using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponSwitching : MonoBehaviour
{
    int fw;
    public AudioClip[] swapClip;
    public float gunIndex;
    public float activeWeapon;
    public GameObject[] rows;
    public int[] rLength;
    public GameObject[] guns;
    public Movement mvmt;
    float swapTime;
    public float curWep;
    public float WNum;
    public int[] rownums;
    public int[] gunOrder;
    float lastIndex;
    int index;
    int highestW;
    float swapTimee;
    bool keysUp;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!mvmt)
            mvmt = FindObjectOfType<Movement>();
        WNum = mvmt.animController.GetInteger("WeaponNum");
        for (int i = 0; i<gunOrder.Length; i++)
        {
            if (gunOrder[i] == WNum)
                gunIndex = i;
        }
        int gunChange = 0;
        if (keysUp)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0f)
                gunChange = -1;
            if (Input.GetAxis("Mouse ScrollWheel") > 0f)
                gunChange = 1;
        }
        int startGun = (int)gunIndex;
        gunIndex +=gunChange;
        keysUp = !(Time.realtimeSinceStartup > swapTime);
        if (lastIndex != gunIndex)
            {
            if (Time.realtimeSinceStartup > 10)
            GetComponent<AudioSource>().PlayOneShot(swapClip[Random.Range(0, swapClip.Length-1)]);
                lastIndex = gunIndex;
            if (gunChange != 0)
            {
                swapTime = Time.realtimeSinceStartup;
                Debug.Log("TRYING TO CHANGE GUN");
                gunIndex += gunChange;
                while (!mvmt.equippedWeapons[(int)(gunOrder[(int)gunIndex])])
                {
                    gunIndex += gunChange;
                    if (gunIndex >= gunOrder.Length)
                        gunIndex = 0;
                    if (gunIndex < 0)
                        gunIndex = gunOrder.Length-1;
                }

                mvmt.animController.SetInteger("WeaponNum", (int)(gunOrder[(int)gunIndex]));
                mvmt.tryEquipWeapon();
            }
            }
        if (!mvmt)
            mvmt = FindObjectOfType<Movement>();
        
        if (mvmt.animController.GetInteger("WeaponNum") != curWep)
        {
            swapTime = Time.realtimeSinceStartup + 3;
            for (int i = 0; i < guns.Length; i++)
            {
                if (guns[i] != null)
                {
                    GameObject g = guns[i];
                    g.SetActive(mvmt.equippedWeapons[i]);
                }
            }
            curWep = rownums[mvmt.animController.GetInteger("WeaponNum")];
            activeWeapon = curWep;
            for (int i = 0; i < rows.Length; i++)
            {
                GameObject g = rows[i];

                Vector3 pos = g.transform.localPosition;
                pos.y = -120 - 20 * rLength[i]; ;
                if (i == activeWeapon)
                    pos.y = -120;
                g.transform.localPosition = pos;
            }
        }
        if (Time.realtimeSinceStartup > swapTime)
        {
            for (int i = 0; i < rows.Length; i++)
            {
                GameObject g = rows[i];
                Vector3 pos = g.transform.localPosition;
                pos.y -= Time.deltaTime * 10;
                g.transform.localPosition = pos;
            }
        }
    }
}
