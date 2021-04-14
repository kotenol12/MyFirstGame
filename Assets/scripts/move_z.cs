using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_z : MonoBehaviour
{
    public float speed;
    public Transform _tran_obj;
    private Vector3 direction;
    public GameObject player;
    public float x1;
    public float x2;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
            player.transform.parent = transform;
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            player.transform.parent = null;
    }

    private void Start()
    {
        _tran_obj = GetComponent<Transform>();
        direction = Vector3.forward;
    }


    private void FixedUpdate()
    {
        _tran_obj.Translate(direction * speed * Time.deltaTime);
        if (_tran_obj.position.z > x1) direction = -Vector3.forward;
        if (_tran_obj.position.z < x2) direction = Vector3.forward;
    }
}
