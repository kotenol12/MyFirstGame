using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_frog : MonoBehaviour
{
    public GameObject frog;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == frog)
            frog.transform.parent = transform;
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject == frog)
            frog.transform.parent = null;
    }
}
