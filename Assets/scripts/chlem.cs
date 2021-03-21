using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chlem : MonoBehaviour
{
    public GameObject chlem1;
    public GameObject chlem1_duck;
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Playerr")
        {
            chlem1.SetActive(false);
            chlem1_duck.SetActive(true);
        }
    }
}
