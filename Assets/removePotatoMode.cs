using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removePotatoMode : MonoBehaviour
{
    public Component[] toRemove;
    public GameObject[] alsoRemove;
    // Start is called before the first frame update
    void Start()
    {
        if (QualitySettings.GetQualityLevel() == 0)
        {
            foreach (Component o in toRemove)
                Destroy(o);
            foreach (GameObject o in alsoRemove)
                Destroy(o);
        }
    }


}
