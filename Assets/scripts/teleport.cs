using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{

    public Transform pos;
    public GameObject player;
    public bool trigger = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
            trigger = true;
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            trigger = false;
    }


    private void FixedUpdate()
    {
        if(trigger==true)
            player.transform.position = pos.transform.position;
    }
}
