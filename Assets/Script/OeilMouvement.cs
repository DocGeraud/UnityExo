using UnityEngine;
using System.Collections;

public class OeilMouvement : MonoBehaviour {

	Animator anim;//ref à l'animator de Eye
	GameObject player;
	CharacterManager MvtJoueur;
	MouseLook RegardJoueur;
	public bool OeilActivay;


	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
		player = GameObject.FindWithTag("Player");
		MvtJoueur = player.GetComponent <CharacterManager> ();
		RegardJoueur = player.GetComponent <MouseLook> ();
		OeilActivay = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0) && anim.GetBool ("OeilMouvement") == false) 
		{
			anim.SetTrigger ("OeilLancement");
		}

		if (Input.GetMouseButtonDown (2)) 
		{
			anim.SetBool ("GameOver", true);
			Debug.Log("Pressed middle click.");
		}


	}

	public void OeilFinMouvement () // lancé à la fin du mvt de l'oeil
	{
		anim.SetBool ("OeilMouvement", false);
		MvtJoueur.enabled = true;
		RegardJoueur.enabled = true;
		OeilActivay = false;
	}

	public void OeilDebutMouvement () // lancé au début du mouvement de l'oeil
	{
		anim.SetBool ("OeilMouvement", true);
		MvtJoueur.enabled = false;
		RegardJoueur.enabled = false;
		OeilActivay = true;
	}


}

