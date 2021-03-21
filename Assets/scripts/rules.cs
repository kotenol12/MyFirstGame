using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rules : MonoBehaviour
{
    public GameObject platform;

    void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "platform")
        {
            transform.position = new Vector3(platform.transform.position.x+0F, platform.transform.position.y+0F, platform.transform.position.z+0F);

        }

    }

}
