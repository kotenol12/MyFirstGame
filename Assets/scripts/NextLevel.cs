using UnityEngine;      
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {      
	
	public int nextlevel = 0;

	void OnTriggerEnter(Collider col)     
	{
		if (Key.Keys == 1 && get_duck.duckkk==1)
		{
			if (col.tag == "Player" ) SceneManager.LoadScene(nextlevel);
		}
	}

}