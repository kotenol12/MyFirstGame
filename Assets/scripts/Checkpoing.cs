using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoing : MonoBehaviour
{

    public GameObject player;
    public void OnTriggerStay(Collider other)
    {
        player.transform.position = this.transform.position;
    }
}
