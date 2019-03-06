using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItem : MonoBehaviour 
{
	public GameObject wall = null;
	public GameObject camera = null;
	public GameObject player = null;
	float temp = 0;
	public float speed;
	public bool startcount = false;

	CharacterMotor playtest;


	void Start()
	{
		playtest = player.GetComponent<CharacterMotor>();

	}

	public void CreateWall()
	{
		GameObject wallTmp;
		Quaternion test = Quaternion.Euler (camera.transform.eulerAngles.x - 24, camera.transform.eulerAngles.y, camera.transform.eulerAngles.z);

		wallTmp = Instantiate (wall, camera.transform.position + new Vector3(0,2,0) +  camera.transform.forward * 5, test);

		wallTmp.SetActive (true);
		float lifetime = 5;

		Destroy (wallTmp, lifetime);


	}

	public void speedBonus()
	{
	 
		player.GetComponent<CharacterMotor>().setSpeed (speed);

		StartCoroutine (sleep ());
			

	}


	IEnumerator sleep()
	{

		yield return new WaitForSeconds (5);
		player.GetComponent<CharacterMotor>().setBackSpeed ();
	}


}