using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sv_menu : MonoBehaviour
{
    public GameObject player;
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

        transform.position = new Vector3(player.transform.position.x+x_koon, player.transform.position.y + y_koon, player.transform.position.z + z_koon);



    }

}
