using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HacerDaño : MonoBehaviour {

	public int Dano=5;
	public float DistanciaObj;
	public float rango = 4;

	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			RaycastHit hit;
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit)) {
				DistanciaObj = hit.distance;
				if (DistanciaObj <= rango) {
					hit.transform.SendMessage ("ReducirVida", Dano, SendMessageOptions.DontRequireReceiver);

				}
			}
		}				
	}
}
