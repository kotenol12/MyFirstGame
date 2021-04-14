using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_lvl2 : MonoBehaviour
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
        if (other.tag == "Player" || other.tag == "Playerr")
        {
            but.GetComponent<Animator>().SetBool("go", true);
            konas.GetComponent<Animator>().SetBool("down", true);
           
        }



    }
    private void OnTriggerExit(Collider other)
    {
        Invoke("plat1",1f);
        but.GetComponent<Animator>().SetBool("go", false);


        konas.GetComponent<Animator>().SetBool("up", true);
        Invoke("plat", 5f);
    }
   void plat(){
        konas.GetComponent<Animator>().SetBool("up", false);
    }
    void plat1()
    {
        konas.GetComponent<Animator>().SetBool("down", false);
    }

    void Update()
    {


    }
}
