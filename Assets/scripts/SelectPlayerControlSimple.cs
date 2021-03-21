using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayerControlSimple : MonoBehaviour
{
	public GameObject Player1;
	public GameObject Player2;
	public GameObject Player1_Camera;
	public GameObject Player2_Camera;
	private CharacterController ch_controler_robot;
	private CharacterController ch_controler_duck;
	public Vector3 OldPosition;
	private bool isPlayered;
	public GameObject Player1_convas;
	public GameObject Player2_convas;




	void Start()
	{
		Vector3 OldPosition = transform.position;
	}


	void Update()
	{

		robot_move _script1 = Player1.GetComponent<robot_move>();

		walk_duck _script2 = Player2.GetComponent<walk_duck>();


		ch_controler_robot = Player1.GetComponent<CharacterController>();
		ch_controler_duck = Player2.GetComponent<CharacterController>();

		


		if (Input.GetKeyDown(KeyCode.G))
		{

			if (isPlayered == false && ch_controler_robot.isGrounded && Spawn.duck_proverka == 1)
			{
				Player1_convas.SetActive(false);
				Player2_convas.SetActive(true);
				_script1.enabled = false;
				_script2.enabled = true;

				Player1_Camera.SetActive(false);
				Player2_Camera.SetActive(true);
				isPlayered = true;

			}
			else if (ch_controler_duck.isGrounded)
			{
				Player1_convas.SetActive(true);
				Player2_convas.SetActive(false);

				_script1.enabled = true;
				_script2.enabled = false;

				Player1_Camera.SetActive(true);
				Player2_Camera.SetActive(false);
				isPlayered = false;

			}
		}
	}
}


