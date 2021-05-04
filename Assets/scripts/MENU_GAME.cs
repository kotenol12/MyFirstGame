using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MENU_GAME : MonoBehaviour
{
   public GameObject buuton_menu;
    public GameObject slider_pers;
    public GameObject slider_music;
    public GameObject button_restart;
    public GameObject button_next;
    public GameObject begin;
    public GameObject Exit;
    public GameObject volue;
    public GameObject music;
    public int nextlevel;
    public GameObject end;

    public void Menu(){
        buuton_menu.SetActive(false);
        slider_pers.SetActive(true);
        slider_music.SetActive(true);
        button_restart.SetActive(true);
        volue.SetActive(true);
        music.SetActive(true);
        button_next.SetActive(true);
        
        Exit.SetActive(true);
    }
    public void next(){
        volue.SetActive(false);
        music.SetActive(false);
        buuton_menu.SetActive(true);
        slider_pers.SetActive(false);
        slider_music.SetActive(false);
        button_restart.SetActive(false);
        button_next.SetActive(false);
        Exit.SetActive(false);
    }
    public void restar(){
        PlayerPrefs.SetInt("duck", 0);
        PlayerPrefs.SetInt("frog", 0);
        SceneManager.LoadScene(0);
        Key.Keys = 0;
        PlayerPrefs.SetInt("proverka", 0);
        
    }
    public void chets()
    {
        PlayerPrefs.SetInt("duck", 1);
        PlayerPrefs.SetInt("frog", 1);
        SceneManager.LoadScene(0);
    }
    public void exit(){
        Application.Quit();
    }
    public void restart()
    {
        SceneManager.LoadScene(nextlevel);
        Key.Keys = 0;
        
    }
    public void delete(){
        begin.SetActive(false);
        end.SetActive(false);
    }
    private void Start()
    {
        if (PlayerPrefs.GetInt("proverka") != 1)
        {
            begin.SetActive(true);
            PlayerPrefs.SetInt("proverka", 1);
        }

        if (PlayerPrefs.GetInt("duck")==1 && PlayerPrefs.GetInt("frog") == 1){
            end.SetActive(true);
        }
    }
}
