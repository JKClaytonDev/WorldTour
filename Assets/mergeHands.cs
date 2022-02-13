using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mergeHands : MonoBehaviour
{
    public GameObject aL;
    public GameObject bR;
    public GameObject a2L;
    public GameObject b2R;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        aL.transform.position = a2L.transform.position;
        bR.transform.position = b2R.transform.position;
    }
}
