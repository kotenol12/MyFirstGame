using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_duck : MonoBehaviour
{

    private CharacterController ch_controller;
    private float gravityForce;
    void Start()
    {
        ch_controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        GamingGravity();
    }

    private void GamingGravity()
    {
        if (!ch_controller.isGrounded)
            gravityForce -= 20f * Time.deltaTime;
        else
            gravityForce = -1f;

    }
}
