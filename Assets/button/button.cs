using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    private Animator ch_animator;
    public GameObject but;
    public GameObject konas;
    // Start is called before the first frame update
    void Start()
    {
        ch_animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Playerr")
        {
            but.GetComponent<Animator>().SetBool("go", true);
            konas.GetComponent<Animator>().SetBool("give", true);
        }

        if (other.tag != "Playerr")
        {
            but.GetComponent<Animator>().SetBool("go", false);
           
        }

    }
    private void OnTriggerExit(Collider other)
    {
       
            but.GetComponent<Animator>().SetBool("go", false);

        
    }
    // Update is called once per frame
    void Update()
    {
           

    }
}
