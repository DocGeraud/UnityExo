using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Etapes : MonoBehaviour {

	public int etape;
	GameObject Yeux;
	Text Texte;
	string[] Phrases = new string[10];

	// Use this for initialization
	void Start () {
		etape = 0;
		Yeux = GameObject.FindWithTag("YeuxTexte");
		Texte = Yeux.GetComponent <Text> ();

		Phrases [0] = "trouve moi";
		Phrases [1] = "le Sang me regarde";
		Phrases [2] = "je suis à ses cotés mais l'éternité me sépare du Soleil";
		Phrases [3] = "je suis l'équilibre entre le Soleil et les Abysses";
		Phrases [4] = "je me serre contre le Sang mais il ne me voit pas";
		Phrases [5] = "je me reflète autant dans les Abysses que dans le Ciel";
		Phrases [6] = "le Poison a toujours un temps d'avance sur moi";
		Phrases [7] = "je contemple l'outil de ton salut";

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) 
		{
			Texte.text = Phrases [etape];
			etape = etape + 1;
		}
	}
}
