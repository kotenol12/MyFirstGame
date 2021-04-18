using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Key : MonoBehaviour
{
    public static int Keys = 0;
    public GameObject key_model;
    public Text hp_bar;

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
    void FixedUpdate()
    {
        hp_bar.text = "X " + Keys;
    }
}
