using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public GameObject player;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
            player.transform.parent = transform;
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            player.transform.parent = null;
    }
}
