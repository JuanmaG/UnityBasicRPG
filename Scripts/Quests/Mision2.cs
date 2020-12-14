using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mision2 : MonoBehaviour {

	public GameObject TheObjective;
	public GameObject nObjetivo;
	public int CloseObjective;
	public GameObject ObjetivoAnterior;

	void Update () {
		if (CloseObjective == 1) {
			if (TheObjective.transform.localScale.y <= 0.0f) {
				CloseObjective = 0;
				TheObjective.SetActive (false);
			} else {
				TheObjective.transform.localScale -= new Vector3 (0.0f, 0.01f, 0.0f);
			}
		}

	}


	void OnTriggerEnter() {
		StartCoroutine (FinishObjective ());
	}

	IEnumerator FinishObjective() {
		TheObjective.SetActive (true);
		ObjetivoAnterior.SetActive (false);
		nObjetivo.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		CloseObjective = 1;
	}

}
