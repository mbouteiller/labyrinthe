using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManagement : MonoBehaviour {

	public GameObject CanvasMenu = null;
	public GameObject GameControllerWindows = null;

	public void GameController ()
	{
		GameObject tmp;
		tmp = Instantiate (GameControllerWindows, new Vector3 (0, 0, 0), Quaternion.identity);
		tmp.transform.SetParent (CanvasMenu.transform);
	}

	public void QuitButton ()
	{
		Application.Quit ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
