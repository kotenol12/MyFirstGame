using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sv_lvl2 : MonoBehaviour
{
    public GameObject player;
    public  new GameObject light;
    public float x_koon = 0;
    public float y_koon = 0;
    public float z_koon = 0;
    public float x_koon2 = 0;
    public float y_koon2 = 0;
    public float z_koon2 = 0;
    private void Update()
    {

        var playercordinatax = player.transform.position.x - 6.66F;
        var playercordinatay = player.transform.position.y + 5.1F;
        var playercordinataz = player.transform.position.z - 0.04F;

        transform.position = new Vector3(x_koon, player.transform.position.y + y_koon, player.transform.position.z + z_koon);

        light.SetActive(false);

        if (player.transform.position.x < -50)
        {

            transform.position = new Vector3(player.transform.position.x+x_koon2, player.transform.position.y + y_koon2, player.transform.position.z + z_koon2);
            transform.rotation = Quaternion.Euler(90.0F, 0.0F, 0.0F);
            light.SetActive(true);

        }
        else
        {
            transform.position = new Vector3(x_koon, player.transform.position.y + y_koon, player.transform.position.z + z_koon);
            transform.rotation = Quaternion.Euler(0.0F, 90.0F, 0.0F);
            light.SetActive(false);
        }

    }
}
