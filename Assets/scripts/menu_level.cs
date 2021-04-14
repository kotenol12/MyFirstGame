using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_level : MonoBehaviour
{
	public int nextlevel = 0;

	void OnTriggerEnter(Collider col)
	{
		
		{
			if (col.tag == "Playerr") SceneManager.LoadScene(nextlevel);
		}
	}

}
