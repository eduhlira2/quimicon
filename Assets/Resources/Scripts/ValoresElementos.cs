﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ValoresElementos : MonoBehaviour {

	public Text massaAtomica, numeroAtomico;
	public static float massaAtomicaFloat;
	public static int numeroAtomicoInt;
	public string nomeElemento;
	public Image jogador;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MudarValores(string ToSave){

		nomeElemento = ToSave;

		if (PlayerPrefs.GetString ("Lutador1") == "Oxigenio" && nomeElemento == "Oxigenio") {
			massaAtomicaFloat = 15.9f; numeroAtomicoInt = 8;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
		}if (PlayerPrefs.GetString ("Lutador2") == "Oxigenio" && nomeElemento == "Oxigenio") {
			massaAtomicaFloat = 15.9f; numeroAtomicoInt = 8;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
		}if (PlayerPrefs.GetString ("Lutador3") == "Oxigenio" && nomeElemento == "Oxigenio") {
			massaAtomicaFloat = 15.9f; numeroAtomicoInt = 8;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
		}

		if (PlayerPrefs.GetString ("Lutador1") == "Zinco" && nomeElemento == "Zinco") {
			massaAtomicaFloat = 65.4f; numeroAtomicoInt = 30;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
		}if (PlayerPrefs.GetString ("Lutador2") == "Zinco" && nomeElemento == "Zinco") {
			massaAtomicaFloat = 65.4f; numeroAtomicoInt = 30;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
		}if (PlayerPrefs.GetString ("Lutador3") == "Zinco" && nomeElemento == "Zinco") {
			massaAtomicaFloat = 65.4f; numeroAtomicoInt = 30;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
		}

		if (PlayerPrefs.GetString ("Lutador1") == "Bromo" && nomeElemento == "Bromo") {
			massaAtomicaFloat = 79.9f; numeroAtomicoInt = 35;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
		}if (PlayerPrefs.GetString ("Lutador2") == "Bromo" && nomeElemento == "Bromo") {
			massaAtomicaFloat = 79.9f; numeroAtomicoInt = 35;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
		}if (PlayerPrefs.GetString ("Lutador3") == "Bromo" && nomeElemento == "Bromo") {
			massaAtomicaFloat = 79.9f; numeroAtomicoInt = 35;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
		}
	}
}
