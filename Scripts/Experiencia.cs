using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experiencia : MonoBehaviour {

	public static int ExperienciaActual;
	public int exp;
	public static int Explvl;

	// Update is called once per frame
	void Update () {
		exp = ExperienciaActual;
		Explvl = Nivel.NivelActual * 100;
		if (exp >= Explvl) {
			Nivel.NivelActual = Nivel.NivelActual + 1;
		}
	}
}
