using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeItem : MonoBehaviour {

	Inventorytest inv;
	void Start ()
	{
		inv = GameObject.Find ("Inventory").GetComponent<Inventorytest> ();
	}
	

	void Update ()
	{
		
	}

	void OnTriggerEnter(Collider col)
	{

		switch (col.gameObject.tag) 
		{
		case "Slot1": 
			if (inv.slot [0] == 0)
			{
				inv.slot [0] += 1;
				inv.Uptadetxt (0, inv.slot [0].ToString());
				Destroy (col.gameObject);
				break;
			} 
			else
				break;

		case "Slot2": 
			if (inv.slot [1] == 0)
			{
				inv.slot [1] += 1;
				inv.Uptadetxt (1, inv.slot [1].ToString());
				Destroy (col.gameObject);
				break;
			} 
			else
				break;
		case "Slot3": 
			if (inv.slot [2] == 0)
			{
				inv.slot [2] += 1;
				inv.Uptadetxt (2, inv.slot [2].ToString());
				Destroy (col.gameObject);
				break;
			} 
			else
				break;

		}

	}
}
