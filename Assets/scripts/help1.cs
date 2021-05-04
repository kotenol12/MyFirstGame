using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class help1 : MonoBehaviour
{
    public GameObject helpp;
    public GameObject helpp1;
    bool prov = false;
    private void OnTriggerStay(Collider other)
    {
        if ((other.tag == "Player" || other.tag == "Playerr" )&& PlayerPrefs.GetInt("duck")!=1)
        {

           
                helpp.SetActive(true);
                

           
               
           
        }
    }
    private void OnTriggerExit(Collider other)
    {
        helpp.SetActive(false);
        helpp1.SetActive(false);
    }
}
