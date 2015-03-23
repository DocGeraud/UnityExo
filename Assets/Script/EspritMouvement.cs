using UnityEngine;
using System.Collections;

public class EspritMouvement : MonoBehaviour {

	Animator anim;//ref à l'animator de Eye
	Animator animYeux;
	GameObject player;
	CharacterManager MvtJoueur;
	MouseLook RegardJoueur;
	GameObject Yeux;


	// Use this for initialization
	void Start () {
	
		anim = GetComponent <Animator> ();
		player = GameObject.FindWithTag("Player");
		MvtJoueur = player.GetComponent <CharacterManager> ();
		RegardJoueur = player.GetComponent <MouseLook> ();
		Yeux = GameObject.FindWithTag("Yeux");
		animYeux = Yeux.GetComponent <Animator> ();


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) 
		{
			anim.SetBool("MindActivated", true);
		}
	
	}

	public void EspritOuvre ()  // doit empecher les mvt du joueur, de la cam, des yeux
	{
		MvtJoueur.enabled = false;
		RegardJoueur.enabled = false;
		//animYeux.SetBool ("OeilMouvement", true);

	}

	public void EspritFerme ()  // doit empecher les mvt du joueur, de la cam, des yeux
	{
		MvtJoueur.enabled = true;
		RegardJoueur.enabled = true;
		anim.SetBool ("MindActivated", false);
		//animYeux.SetBool ("OeilMouvement", false);
		
	}


}
