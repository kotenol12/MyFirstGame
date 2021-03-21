using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public static int Keys = 0;
    public GameObject key_model;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            Keys += 1;
            Destroy(other.gameObject);
        }

    }
    void Update()
    {

    }
}
