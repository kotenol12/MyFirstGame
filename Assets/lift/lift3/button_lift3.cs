using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_lift3 : MonoBehaviour
{
    private Animator ch_animator;
    public GameObject but;
    public GameObject konas;
    public new GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        ch_animator = GetComponent<Animator>();
        light.GetComponent<Light>().color = new Color(255.0f, 0.0f, 0.0f);
      

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            but.GetComponent<Animator>().SetBool("go", true);
            konas.GetComponent<Animator>().SetBool("down", true);
            light.GetComponent<Light>().color = new Color(0.0f, 255.0f, 0.0f);


        }

    }

    void OnTriggerExit(Collider other)
    {
      
        Invoke("plat1", 1f);
        but.GetComponent<Animator>().SetBool("go", false);
        
        konas.GetComponent<Animator>().SetBool("up", true);
        Invoke("plat", 5f);
    } 
    void plat()
    {
        konas.GetComponent<Animator>().SetBool("up", false);
        light.GetComponent<Light>().color = new Color(255.0f, 0.0f, 0.0f);
    }
    void plat1()
    {
        konas.GetComponent<Animator>().SetBool("down", false);
    }
    void clear(){

    }
}
