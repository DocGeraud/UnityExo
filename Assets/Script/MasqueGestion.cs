using UnityEngine;
using System.Collections;

public class MasqueGestion : MonoBehaviour {


	Light Lumiere;
	public float EtapeMasque;
	GameObject player;
	Etapes EtapeScript;
	float EtapeActuelle;
	OeilMouvement OeilScript;
	GameObject yeux;
	bool OeilActif;


	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		Lumiere = GetComponentInChildren<Light>();
		EtapeScript = player.GetComponent<Etapes> ();
		yeux = GameObject.FindWithTag("Yeux");
		OeilScript = yeux.GetComponent<OeilMouvement> ();
	}
	
	// Update is called once per frame
	void Update () {
		EtapeActuelle = EtapeScript.etape;
		//OeilActif = OeilScript.OeilActivay;     // DOIT ETRE REACTIVAY

		if (EtapeMasque > EtapeActuelle) {
			Lumiere.enabled = false;
		}
		if (EtapeMasque == EtapeActuelle) {
			Lumiere.enabled = true;
		}
	}

	/*void OnTriggerStay(Collider other) {       // DOIT ETRE REACTIVAY
		if (other.attachedRigidbody) 
		{
			Debug.Log ("LOL");
			if (OeilActif = true)
			{

			}
		}
		*/
}


