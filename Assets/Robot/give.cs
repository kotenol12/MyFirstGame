using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class give : MonoBehaviour
{
    public GameObject duck;
    public GameObject duck_robot;
    public void OnTriggerStay(Collider other)
    {
    
        if (Input.GetKeyDown(KeyCode.E))
           
            {
            duck.transform.parent = null;
            duck.SetActive(true);
            duck_robot.SetActive(false);
            get_duck.duckkk -=1 ;
            
        }

    }
}
