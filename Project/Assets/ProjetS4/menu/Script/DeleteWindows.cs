using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWindows : MonoBehaviour {

	[SerializeField]
	public GameObject windows = null;

	public void DestroyGameObject()
	{
		Destroy (windows);
	}
}
