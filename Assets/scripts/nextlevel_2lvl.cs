using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel_2lvl : MonoBehaviour
{ 
	static public int frog_spawn = 0;
	public int nextlevel = 0;

void OnTriggerEnter(Collider col)
{
	if (Key.Keys == 1 && get_duck.duckkk == 1)
	{
		if (col.tag == "Player")
		{
				PlayerPrefs.SetInt("frog", 1);
				SceneManager.LoadScene(nextlevel);

		}

	}
}
}
