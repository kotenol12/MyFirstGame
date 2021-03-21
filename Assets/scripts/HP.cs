using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour {
    public int hp = 3;
    public Text hp_bar;
    public GameObject heale_model;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Damage")
        {
            hp -= 1;
        }
        if (other.tag == "Heale")
        {
            hp += 1;
            Destroy(other);

        }
    }
    void FixedUpdate(){

    if(hp<1){
            transform.position = new Vector3(PlayerPrefs.GetFloat("xPos_duck"), PlayerPrefs.GetFloat("yPos_duck"), PlayerPrefs.GetFloat("zPos_duck"));
            Invoke("plus", 0.0001f);
        }
        hp_bar.text = "X " + hp;
    }
    void plus() {
        hp = 1;
    }
}
