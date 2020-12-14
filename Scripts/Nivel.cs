using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel : MonoBehaviour {

	public static int NivelActual=1;
	public int lvl;
	public GameObject ShowLvl;
	// Update is called once per frame

	void Update () {
		lvl = NivelActual;
	}
}
