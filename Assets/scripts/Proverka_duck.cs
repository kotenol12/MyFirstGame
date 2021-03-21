using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proverka_duck : MonoBehaviour
{
    private Animator ch_animator;
    private Vector3 moveVector;
    public float speedMove;
    private CharacterController ch_controller;
    private float gravityForce;

    void Start()
    {
        ch_animator = GetComponent<Animator>();

        ch_controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal") * speedMove;
        moveVector.z = Input.GetAxis("Vertical") * speedMove;
        if (moveVector.x != 0 || moveVector.z != 0) ch_animator.SetBool("walk", true);
        else ch_animator.SetBool("walk", false);

    }
}
