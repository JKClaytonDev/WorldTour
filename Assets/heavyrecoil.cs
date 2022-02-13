using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class heavyrecoil : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (SceneManager.GetActiveScene().name != "HeavyRecoil")
        {
            SceneManager.LoadScene("HeavyRecoil");
            Destroy(gameObject);
        }
        else
        {
            Application.OpenURL("https://store.steampowered.com/app/933030/Heavy_Recoil/");
            SceneManager.LoadScene("SkyCity1");
        }
        

    }
}
