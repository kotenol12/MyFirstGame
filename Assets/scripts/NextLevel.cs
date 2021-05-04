using UnityEngine;      
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
	static public int duck_spawn =0;
	public int nextlevel = 0;

	void OnTriggerEnter(Collider col)     
	{
		if (Key.Keys == 1 && get_duck.duckkk==1)
		{
			if (col.tag == "Player")
			{
				PlayerPrefs.SetInt("duck", 1);
				SceneManager.LoadScene(nextlevel);
				Key.Keys = 0;
			}
			
		}
	}

}