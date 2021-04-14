using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu_spawn : MonoBehaviour
{
   public GameObject duck;
    public GameObject frog;
    private void Start()
    {
        
        if (PlayerPrefs.GetInt("frog")== 1) frog.SetActive(true); else frog.SetActive(false);
        if (PlayerPrefs.GetInt("duck")==1) duck.SetActive(true); else duck.SetActive(false);
    }

    void Update()
    {
        if (NextLevel.duck_spawn == 1)
        {
            duck.SetActive(true);
            PlayerPrefs.SetInt("duck", 1);
        }
       


        if (nextlevel_2lvl.frog_spawn==1)
        {
            duck.SetActive(true);
            PlayerPrefs.SetInt("frog", 1);
        }




    }



}
