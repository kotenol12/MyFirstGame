using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject duck;
    public int level = 0;
    public GameObject menu;
    
    void Start()
    {
        
       

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (transform.position.y < -20f && Spawn.duck_proverka!=1)
        {       
            transform.position = new Vector3(PlayerPrefs.GetFloat("xPos"), PlayerPrefs.GetFloat("yPos"), PlayerPrefs.GetFloat("zPos"));
            HP.hp -= 1;
        }
        else if(transform.position.y < -20f && Spawn.duck_proverka == 1)
        {
            
            transform.position = new Vector3(PlayerPrefs.GetFloat("xPos"), PlayerPrefs.GetFloat("yPos"), PlayerPrefs.GetFloat("zPos"));
            duck.transform.position = new Vector3(PlayerPrefs.GetFloat("xPos"), PlayerPrefs.GetFloat("yPos"), PlayerPrefs.GetFloat("zPos") - 1);
            HP.hp -= 1;
        }
        if (HP.hp <= 0)
        {
            gameObject.SetActive(false);
            menu.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Checkpoing"){
            PlayerPrefs.SetFloat("xPos", transform.position.x);
            PlayerPrefs.SetFloat("yPos", transform.position.y);
            PlayerPrefs.SetFloat("zPos", transform.position.z);
        }
    }

}
