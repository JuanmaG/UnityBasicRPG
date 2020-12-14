using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mision4 : MonoBehaviour {
	public float distancia;
	public GameObject ActionDisplay;
	public GameObject EspadaFalsa;
	public GameObject EspadaReal;
	public GameObject ActionText;
	public GameObject TheObjective;
	public GameObject nObjetivo;
	public GameObject Objetivoanterior;
	public int CloseObjective;

	void Update () {
		distancia = PlayerCast.DistanceFromTarget;
		if (CloseObjective == 1) {
			if (TheObjective.transform.localScale.y <= 0.0f) {
				CloseObjective = 0;
				TheObjective.SetActive (false);

			} else {
				TheObjective.transform.localScale -= new Vector3 (0.0f, 0.01f, 0.0f);
			}
		}
	}
	void OnMouseOver(){
		if (distancia <= 3) {
			ActionText.GetComponent<Text> ().text = "Equipar Arma";
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}
		if (Input.GetButtonDown ("Action")) {
			if (distancia <= 3) {
				this.GetComponent<BoxCollider> ().enabled = false;
				EspadaFalsa.SetActive (false);
				EspadaReal.SetActive (true);
				Objetivoanterior.SetActive (false);
				TheObjective.SetActive (true);
				nObjetivo.SetActive (true);
				CloseObjective = 1;
				ActionText.SetActive (false);
				ActionDisplay.SetActive (false);
			}
		}
	}
	void OnMouseExit(){
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
		

}
