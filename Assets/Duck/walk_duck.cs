using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk_duck : MonoBehaviour
{
    public float speedMove;
    public float jumpPower;

    private float gravityForce;
    private Vector3 moveVector;

    private CharacterController ch_controller;
    private Animator ch_animator;

    public float speed_rotation = 3;
    void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        ch_animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        CharacterMove();
        GamingGravity();
    }

    private void CharacterMove()
    {


        //  ch_animator.ResetTrigger("jump");
        //  ch_animator.SetBool("falling", false);
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal") * speedMove;
        moveVector.z = Input.GetAxis("Vertical") * speedMove;

        if (moveVector.x != 0 || moveVector.z != 0) ch_animator.SetBool("walk", true);
        else ch_animator.SetBool("walk", false);
        if (Vector3.Angle(Vector3.forward, moveVector) > 1f || Vector3.Angle(Vector3.forward, moveVector) == 0)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, moveVector, speedMove, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }

        moveVector.y = gravityForce;
        ch_controller.Move(moveVector * Time.deltaTime);
    }
    private void GamingGravity()
    {
        if (!ch_controller.isGrounded)
            gravityForce -= 20f * Time.deltaTime;
        else
            gravityForce = -1f;
        if (Input.GetKeyDown(KeyCode.Space) && ch_controller.isGrounded)
        {
            gravityForce = jumpPower;
            // ch_animator.SetTrigger("jump");
        }
    }
}
