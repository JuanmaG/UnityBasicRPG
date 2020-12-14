using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinematica : MonoBehaviour {
	public GameObject Camara1;
	public GameObject Camara2;
	public GameObject DifuminadoEntrada;
	public GameObject DifuminadoSalida;
	public GameObject jugador;

	void Start(){
		StartCoroutine (CinematicaStart ());
	}
	IEnumerator CinematicaStart(){
		yield return new WaitForSeconds (4.5f);
		Camara2.SetActive (true);
		Camara1.SetActive (false);
		DifuminadoEntrada.SetActive (false);
		yield return new WaitForSeconds (4);
		DifuminadoSalida.SetActive (true);
		yield return new WaitForSeconds (1);
		DifuminadoSalida.SetActive (false);
		jugador.SetActive (true);
		DifuminadoEntrada.SetActive (true);
		yield return new WaitForSeconds (2);
		DifuminadoEntrada.SetActive (false);
	}

}
