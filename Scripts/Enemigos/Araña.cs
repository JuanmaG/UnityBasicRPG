using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Araña : MonoBehaviour {

	public int hp=10;
	public GameObject arana;
	public int estado;
	public int ExperienciaBase = 10;
	public int calculo;
	public AI Aiscript;
	public static int AranaGlobal;
	void Start(){
		Aiscript = GetComponent<AI> ();
	}

	void ReducirVida(int Dano){
		hp -= Dano;
	}
	void Update(){
		AranaGlobal = estado;
		if (hp <= 0) {
			if (estado == 0) {
				StartCoroutine (Muerte ());
			}
		}
	}
	IEnumerator Muerte(){
		Aiscript.enabled = false;
		estado = 6;
		calculo = ExperienciaBase * Nivel.NivelActual;
		Experiencia.ExperienciaActual += calculo;
		yield return new WaitForSeconds (0f);
		arana.GetComponent<Animation> ().Play ("die");
	}
}
