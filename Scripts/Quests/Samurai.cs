using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Samurai : MonoBehaviour {

	public float distancia;
	public GameObject ActionDisplay;
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
			ActionText.GetComponent<Text> ().text = "Hablar";
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}
		if (Input.GetButtonDown ("Action")) {
			if (distancia <= 3) {
				Objetivoanterior.SetActive (false);
				TheObjective.SetActive (true);
				nObjetivo.SetActive (true);
				Experiencia.ExperienciaActual += 100;
				CloseObjective = 3;
				ActionText.SetActive (false);
				ActionDisplay.SetActive (false);
				TheObjective.SetActive (false);
			}
		}
	}
	void OnMouseExit(){
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}

}