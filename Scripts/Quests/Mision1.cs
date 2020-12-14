using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mision1 : MonoBehaviour {

	public float distancia;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject Rewards;
	public GameObject TheObjective;
	public GameObject nObjetivo;
	public int CloseObjective;

	void Update () {
		distancia = PlayerCast.DistanceFromTarget;
		if (CloseObjective == 1) {
			if (TheObjective.transform.localScale.y <= 0.0f) {
				CloseObjective = 0;
				TheObjective.SetActive (false);
				Rewards.SetActive (false);

			} else {
				TheObjective.transform.localScale -= new Vector3 (0.0f, 0.01f, 0.0f);
			}
		}
	}
	void OnMouseOver(){
		if (distancia <= 3) {
			ActionText.GetComponent<Text> ().text = "Leer Cartel";
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}
		if (Input.GetButtonDown ("Action")) {
			if (distancia <= 3) {
				StartCoroutine (FinishObjective ());
				Rewards.SetActive (true);
			}
		}
	}
	void OnMouseExit(){
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}

	IEnumerator FinishObjective() {
		TheObjective.SetActive (true);
		nObjetivo.SetActive (true);
		yield return new WaitForSeconds (1.5f);
		CloseObjective = 1;
	}
}
