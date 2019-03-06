using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {


	//Animation du perso
	Animator animations;

	//Vitesse de déplacement
	public float walkSpeed;
	public float runSpeed;
	public float turnSpeed;

	//Input
	public string inputFront;
	public string inputBack;
	public string inputLeft;
	public string inputRight;

	public Vector3 jumpSpeed; //Hauteur du saut
	CapsuleCollider playerCollider;


	void Start () {
		animations = GetComponent<Animator>(); 
		playerCollider = gameObject.GetComponent<CapsuleCollider>();
	}
	

	void Update () {

		//Si le joueur avance
		if (Input.GetKey(inputFront) && !Input.GetKey(KeyCode.LeftShift)) 
		{
			//Joue l'animation de marche
			animations.SetInteger("Conditions", 1);
			transform.Translate(0, 0, walkSpeed * Time.deltaTime);
		}

		//Si le joueur arrête d'avancer
		if (Input.GetKeyUp(inputFront)) 
		{
			//Le personnage arrête de marcher
			animations.SetInteger("Conditions", 0);
			transform.Translate(0, 0, 0);
		}

		//Si le joueur cours
		if (Input.GetKey(inputFront) && Input.GetKey(KeyCode.LeftShift)) 
		{
			//Le personnage cours
			animations.SetInteger ("Conditions", 2);
			transform.Translate(0, 0, runSpeed * Time.deltaTime);
		}

		//Si le joueur cours plus
		if (!Input.GetKey(inputFront) && Input.GetKey(KeyCode.LeftShift)) 
		{
			//Le personnage cours plus
			animations.SetInteger ("Conditions", 0);
		}

		//Si le joueur recule
		if (Input.GetKey(inputBack) && !Input.GetKey(inputFront) && !Input.GetKey(inputRight) && !Input.GetKey(inputLeft)) 
		{
			//Le personnage recule
			animations.SetInteger ("Conditions", 3);
			transform.Translate(0, 0, -(walkSpeed / 2) * Time.deltaTime);
		}

		//Si le joueur arrête de reculer 
		if (Input.GetKeyUp(inputBack) && !Input.GetKey(inputFront) && !Input.GetKey(inputRight) && !Input.GetKey(inputLeft)) 
		{
			//Le personnage recule
			animations.SetInteger ("Conditions", 0);
		}

		//Rotation à gauche
		if (Input.GetKey (inputLeft))
		{
			//Animation du personnage(rotation)
			//animations.SetInteger ("Conditions", 4);
			transform.Rotate (0, -turnSpeed * Time.deltaTime, 0);
		} 

		//Rotation à droite
		if (Input.GetKey (inputRight)) 
		{
			//animations.SetInteger ("Conditions", 3);
			transform.Rotate (0, turnSpeed * Time.deltaTime, 0);
		} 
	}
}
