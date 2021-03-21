using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_duck : MonoBehaviour
{
    public GameObject duck;
    public GameObject duck_robot;
    public GameObject player;
    public static int duckkk=0;
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                duck.SetActive(false);
                duck_robot.SetActive(true);
                duck.transform.parent = player.transform;
                duckkk += 1;
            }
        }
    }
}
