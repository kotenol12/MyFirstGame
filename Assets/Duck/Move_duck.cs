using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_duck : MonoBehaviour
{

    public float Speed = 3;
    Animator anim;
    void Start()
    {
       

        anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        Move();
    }
    void Move()
    {
        float Hor = Input.GetAxis("Horizontal");
        float Ver= Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(Hor, 0.0f, Ver);
        if(mov!=Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(mov), 0.15f);
           // anim.SetInteger("walk", 1);
        }
        else{
            //anim.SetInteger("walk", 0);
        }
        transform.Translate(mov * Speed * Time.deltaTime, Space.World);

    }
}
