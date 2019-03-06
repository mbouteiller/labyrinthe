using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour {


	Inventorytest inv;
	void Start()
	{
		inv = GameObject.Find ("Inventory").GetComponent<Inventorytest> ();
	}

	public void Selection ()
	{
		int nbSlot = transform.parent.GetSiblingIndex ();

		if (inv.slot [nbSlot] != 0) 
		{
			inv.slot [nbSlot] -= 1;
			inv.Uptadetxt (nbSlot, inv.slot [nbSlot].ToString ());
		}
	

	}
	

	void Update () 
	{
		
	}
}
