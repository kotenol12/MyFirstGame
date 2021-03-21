using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{

    public Transform pos;
    public GameObject player;
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject==player)
            other.transform.position = pos.transform.position;
        
    }
}
