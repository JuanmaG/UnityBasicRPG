using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacar : MonoBehaviour {

	public GameObject Espada;
	public int status;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && status == 0) {
			StartCoroutine (HardAtackFunction ());
		}
		if (Input.GetButtonDown ("Fire2") && status == 0) {
			StartCoroutine (LightAtackFunction ());
		}
	}

	IEnumerator HardAtackFunction(){
		status = 1;
		Espada.GetComponent<Animation> ().Play ("HardSwing");
		status = 2;
		yield return new WaitForSeconds (0.5f);
		status = 0;
	}
	IEnumerator LightAtackFunction(){
		status = 1;
		Espada.GetComponent<Animation> ().Play ("Estocada");
		status = 2;
		yield return new WaitForSeconds (0.5f);
		status = 0;
	}
}
