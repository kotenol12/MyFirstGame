using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int money = 0;
    public Text money_bar;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "money")
        {
           money += 1;
            Destroy(other.gameObject);
        }
        
    }
    void Update()
    {

        money_bar.text = "X " + money;
    }
}
