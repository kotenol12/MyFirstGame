using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over_duck : MonoBehaviour
{
    public GameObject duck;
    public int level = 0;

    void Start()
    {
      


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (transform.position.y < -5f)
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("xPos_duck"), PlayerPrefs.GetFloat("yPos_duck"), PlayerPrefs.GetFloat("zPos_duck"));
            
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Checkpoing")
        {
            PlayerPrefs.SetFloat("xPos_duck", transform.position.x);
            PlayerPrefs.SetFloat("yPos_duck", transform.position.y);
            PlayerPrefs.SetFloat("zPos_duck", transform.position.z);
        }
    }
}
