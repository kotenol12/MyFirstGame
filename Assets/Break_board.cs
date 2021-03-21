using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break_board : MonoBehaviour
{

    public GameObject but;

    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Playerr")
        {
            but.GetComponent<Animator>().SetBool("break", true);
        }


    }
}
