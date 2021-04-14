using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MENU_GAME : MonoBehaviour
{
   public GameObject buuton_menu;
    public GameObject background;
    public GameObject button_restart;
    public GameObject button_next;
    public GameObject chet;
    public GameObject Exit;
    public int nextlevel;
    public void Menu(){
        buuton_menu.SetActive(false);
        background.SetActive(true);
        button_restart.SetActive(true);
        button_next.SetActive(true);
        chet.SetActive(true);
        Exit.SetActive(true);
    }
    public void next(){
        buuton_menu.SetActive(true);
        background.SetActive(false);
        button_restart.SetActive(false);
        button_next.SetActive(false);
        chet.SetActive(false);
        Exit.SetActive(false);
    }
    public void restar(){
        PlayerPrefs.SetInt("duck", 0);
        PlayerPrefs.SetInt("frog", 0);
        SceneManager.LoadScene(0);
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
    }
}
