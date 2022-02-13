using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandLOD : MonoBehaviour {

    Movement player;
    float frames = 0;
    public GameObject far;
public GameObject close;
    Vector3 closeSize;
    public float distance;
    public float dist;
    public float quality;
    public Mesh low;
    public Mesh high;
    public MeshFilter filter;
    float distanceThreshold;
    bool lastDist;
    // Start is called before the first frame update

    private void Start()
    {
        Time.fixedDeltaTime = 0.02f;
        quality = QualitySettings.GetQualityLevel();
        distanceThreshold = (quality+1)*(quality + 1) * (quality + 1) * 25;
        if (QualitySettings.GetQualityLevel() == 0)
        {
            //Time.fixedDeltaTime = 0.04f;
            filter.mesh = low;
            this.enabled = false;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        frames++;
        if (frames > 60)
        {
            frames = 0;
            if (!player)
                player = FindObjectOfType<Movement>();
            dist = Vector3.Distance(transform.position, player.transform.position);
            if (lastDist != dist < distanceThreshold)
            {
                if (dist < distanceThreshold)
                    filter.mesh = high;
                else
                    filter.mesh = low;
            }
            lastDist = dist < distanceThreshold;
        }
    }
}
