using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	public GameObject Jugador;
	public float distanciaObj;
	public float rango = 40;
	public GameObject enemigo;
	public float VelocidadEnemigo;
	public int TriggerAtaque;
	public RaycastHit Shot;
	public int HaciendoDano;


	void Update (){
		transform.LookAt (Jugador.transform);
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out Shot)){
			distanciaObj = Shot.distance;
			if (distanciaObj <= rango) {
				VelocidadEnemigo = 0.05f;
				if (TriggerAtaque == 0) {
					enemigo.GetComponent<Animation> ().Play ("walk");
					transform.position = Vector3.MoveTowards (transform.position, Jugador.transform.position, VelocidadEnemigo);
				}
			} else {
				VelocidadEnemigo = 0;
				enemigo.GetComponent<Animation> ().Play ("idle");
			}
		}
		if (TriggerAtaque == 1) {
			if (HaciendoDano == 0) {
				VelocidadEnemigo = 0;
				enemigo.GetComponent<Animation> ().Play ("attack");
				StartCoroutine (RecibiendoDano ());
			}
		}
	}
	void OnTriggerEnter(){
		TriggerAtaque = 1;
	}
	void OnTriggerExit(){
		TriggerAtaque = 0;
	}
	IEnumerator RecibiendoDano(){
		HaciendoDano = 2;
		yield return new WaitForSeconds (0.5f);
		if (Araña.AranaGlobal != 6) {
			ControladorHp.ValorVida -= 1;
		}
		yield return new WaitForSeconds (0.5f);
			HaciendoDano = 0;
	}
}
