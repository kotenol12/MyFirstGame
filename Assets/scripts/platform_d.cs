using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_d : MonoBehaviour
{
    Rigidbody platform;
    Vector3 Curr;
    public GameObject player;
    bool moveback;
    public GameObject plat;
 
    void Start()
    {
        platform = GetComponent<Rigidbody>();
        Curr = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveback == true){
            transform.position = Vector3.MoveTowards(transform.position, Curr, 20 * Time.deltaTime);
        }
        if(transform.position.y == Curr.y){
            moveback = false;
        }
    }
   
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Playerr" && moveback == false || other.tag == "Player")
        {
            Invoke("FallPlatform", 1f);
          
        }
    }

    void backPlatform(){
        platform.velocity = Vector3.zero;
        platform.isKinematic = true;
        moveback = true;
        Invoke("activeon", 2f);
    }

    void FallPlatform()
    {
        platform.isKinematic = false;
        Invoke("backPlatform", 1f);
        Invoke("activeoff", 1f);
    }
    void activeoff(){
        plat.SetActive(false);
    }
    void activeon()
    {
        plat.SetActive(true);
    }


}
