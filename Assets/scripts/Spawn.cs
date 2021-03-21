using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject prefab;
    public static float duck_proverka;
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "bush")
        {
            prefab.SetActive(true);
            duck_proverka = 1; 
            
        }


    }
}
