﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour {

	public Image fighter, fighter2, fighter3;
	private int aux;
	public GameObject battle, anim1, anim2, anim3;
	//public GameObject lutador1, lutador2, lutador3;

	// Use this for initialization
	void Start () {
		aux = 0;
	}
	void Update () {

	}

	public void ChangeImagefirst(string nameImage){



		if(aux == 2){
			fighter3.sprite = Resources.Load<Sprite> ("Sprites/"+nameImage)as Sprite;
			battle.SetActive(true);
			PlayerPrefs.SetString("Lutador3", nameImage);
			//lutador3 = Resources.Load<GameObject> ("Prefabs/"+nameImage)as GameObject;
			anim3.GetComponent<Animator>().Play("Primeiro_Becker");
		}
		if(aux == 1){
			fighter2.sprite = Resources.Load<Sprite> ("Sprites/"+nameImage)as Sprite;
			aux = aux+1;
			//lutador2 = Resources.Load<GameObject> ("Prefabs/"+nameImage)as GameObject;
			PlayerPrefs.SetString("Lutador2", nameImage);
			anim2.GetComponent<Animator>().Play("Primeiro_Becker");
		}
		if(aux == 0){
			fighter.sprite = Resources.Load<Sprite> ("Sprites/"+nameImage)as Sprite;
			aux = 1;
			PlayerPrefs.SetString("Lutador1", nameImage);
			//lutador1 = Resources.Load<GameObject> ("Prefabs/"+nameImage)as GameObject;
			anim1.GetComponent<Animator>().Play("Primeiro_Becker");
		}
		this.GetComponent<Button> ().enabled = false;

	}

	public void ZerarPlayers(){
		this.aux = 0;
		fighter.sprite = Resources.Load<Sprite> ("Sprites/Hud/becker")as Sprite;			
		fighter2.sprite =Resources.Load<Sprite> ("Sprites/Hud/becker")as Sprite;	
		fighter3.sprite = Resources.Load<Sprite> ("Sprites/Hud/becker")as Sprite;

		battle.SetActive(false);
	}
}

