using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agent : MonoBehaviour
{

    public GameObject target;
    void Update()
    {
        transform.LookAt(target.transform.position); 
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime); 
    }
}

