using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Inventorytest : MonoBehaviour {

	bool active = false;
	GameObject p;
	public int[] slot;
	UseItem ui;


	void Start () 
	{
		p = transform.GetChild (0).gameObject;
		slot = new int[p.transform.childCount];	
		ui = GameObject.Find ("createWallBonus").GetComponent<UseItem> ();
	}
	

	void Update ()
	{
		/*if (Input.GetKeyDown (KeyCode.I))
		{
			/active = !active;

			if (!active)
			{
				player.GetComponent<RigidbodyFirstPersonController> ().enabled = true;
			}
			else 
			{
				player.GetComponent<RigidbodyFirstPersonController> ().enabled = false;
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
			GetComponent<Canvas>().enabled = active;

		}*/

		if (Input.GetKeyDown (KeyCode.A)) 
		{
			if (slot [0] != 0) 
			{
				UtilObj1 ();

				ui.CreateWall ();
			}

		}
		if (Input.GetKeyDown (KeyCode.E)) 
		{
			if (slot [1] != 0) 
			{
				UtilObj2 ();

				ui.speedBonus ();

			}

		}
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			if (slot [2] != 0) 
			{
				UtilObj3 ();

			}

		}

	}

	public void Uptadetxt(int nbSlot, string txt)
	{
		p.transform.GetChild (nbSlot).GetChild (0).GetComponent<Text>().text = txt;
	}

	public void UtilObj1 ()
	{
		int nbSlot = p.transform.GetChild(0).GetSiblingIndex ();

		if (slot [nbSlot] != 0) 
		{
			slot [nbSlot] -= 1;
			Uptadetxt (nbSlot, slot [nbSlot].ToString ());
		}


	}
	public void UtilObj2 ()
	{
		int nbSlot = p.transform.GetChild(1).GetSiblingIndex ();

		if (slot [nbSlot] != 0) 
		{
			slot [nbSlot] -= 1;
			Uptadetxt (nbSlot, slot [nbSlot].ToString ());
		}


	}
	public void UtilObj3 ()
	{
		int nbSlot = p.transform.GetChild(2).GetSiblingIndex ();

		if (slot [nbSlot] != 0) 
		{
			slot [nbSlot] -= 1;
			Uptadetxt (nbSlot, slot [nbSlot].ToString ());
		}


	}
}
