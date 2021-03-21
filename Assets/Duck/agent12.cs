using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agent12 : MonoBehaviour
{
    [SerializeField]
    private Transform ObjA;
    [SerializeField]
    private Transform ObjB;
    [SerializeField]
    [Tooltip("Расстояние для начала следования")]
    private float n;
    public float Speed = 3;

    void Update()
    {
        Vector3 A_pos = ObjA.position;
        Vector3 B_pos = ObjB.position;
        if ((A_pos - B_pos).magnitude >= n)

            Go();
        else Move(); //метод обычного движения от одной точки к другой
    }
    private void Go()
    {
        Vector3 position = ObjA.position;
        transform.position = Vector3.MoveTowards(transform.position, position, Speed * Time.deltaTime);
    }
    void Move()
    {
        float Hor = Input.GetAxis("Horizontal");
        float Ver = Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(Hor, 0.0f, Ver);
        if (mov != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(mov), 0.15f);
          
        }
        else
        {
            
        }
        transform.Translate(mov * Speed * Time.deltaTime, Space.World);

    }
}

