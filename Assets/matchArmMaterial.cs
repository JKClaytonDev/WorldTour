using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matchArmMaterial : MonoBehaviour
{
    float frames = 0;
        public SkinnedMeshRenderer mat;
    MeshRenderer m;
    // Update is called once per frame
    void Start()
    {
        m = GetComponent<MeshRenderer>();
    }
    void FixedUpdate()
    {
        frames++;
        if (frames > 15)
        {
            if (m.material != mat.material)
                m.material = mat.material;
            frames = 0;
            }
        }
}
