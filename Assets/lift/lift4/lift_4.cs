using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift_4 : MonoBehaviour
{
    private Animator ch_animator;
    public GameObject but;
    public GameObject but2;
    public GameObject but3;
    public GameObject konas;
    public new GameObject light;
    public bool butt1 = false;
    public bool butt2 = false;
    public bool butt3 = false;

    // Start is called before the first frame update
    void Start()
    {
        ch_animator = GetComponent<Animator>();
        light.GetComponent<Light>().color = new Color(255.0f, 0.0f, 0.0f);


    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "but1")
        {
            but2.GetComponent<Animator>().SetBool("go", true);
            light.GetComponent<Light>().color = new Color(0.0f, 255.0f, 0.0f);
            butt1 = true;

        }
       else if(other.tag!="but2" && other.tag != "but3")
        {
            but2.GetComponent<Animator>().SetBool("go", true);
            light.GetComponent<Light>().color = new Color(255.0f, 0.0f, 0.0f);
            butt1 = false;
        }
       
        if(other.tag == "but2" && butt1==true ){
            but.GetComponent<Animator>().SetBool("go", true);
            light.GetComponent<Light>().color = new Color(0.0f, 255.0f, 0.0f);
            butt2 = true;
        }
        else if (other.tag != "but1" && other.tag != "but3")
        {
            
            but2.GetComponent<Animator>().SetBool("go", false);
            but.GetComponent<Animator>().SetBool("go", true);
            light.GetComponent<Light>().color = new Color(255.0f, 0.0f, 0.0f);
            butt2 = false;
        }
       
        if (other.tag == "but3" && butt2 == true)
        {
            but3.GetComponent<Animator>().SetBool("go", true);
            konas.GetComponent<Animator>().SetBool("down", true);
            light.GetComponent<Light>().color = new Color(0.0f, 255.0f, 0.0f);
           
            butt3 = true;
        }
        else if (other.tag != "but1" && other.tag != "but2")
        {

            but2.GetComponent<Animator>().SetBool("go", false);
            but.GetComponent<Animator>().SetBool("go", false);
            but3.GetComponent<Animator>().SetBool("go", true);
            light.GetComponent<Light>().color = new Color(255.0f, 0.0f, 0.0f);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "but2"&&butt1==false){
            but.GetComponent<Animator>().SetBool("go", false);
        }
        if (other.tag == "but3" && butt2 == false)
        {
            but3.GetComponent<Animator>().SetBool("go", false);
        }

        if (butt3==true){ 
        Invoke("plat1", 1f);
        but.GetComponent<Animator>().SetBool("go", false);

        konas.GetComponent<Animator>().SetBool("up", true);
        Invoke("plat", 5f);}
    }
    void plat()
    {
        konas.GetComponent<Animator>().SetBool("up", false);
        light.GetComponent<Light>().color = new Color(255.0f, 0.0f, 0.0f);
        butt3 = false;
    }
    void plat1()
    {
        konas.GetComponent<Animator>().SetBool("down", false);
    }
}
