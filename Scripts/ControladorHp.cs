using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorHp : MonoBehaviour {

	public static int ValorVida;
	public int VidaInterna;
	public GameObject Corazon1;
	public GameObject Corazon2;
	public GameObject Corazon3;

	void Start () {
		ValorVida = 3;
	}
	
	// Update is called once per frame
	void Update () {
		ValorVida = ValorVida;
		if (ValorVida <= 0) {
			SceneManager.LoadScene (1);
		}
		if (ValorVida == 1) {
			Corazon1.SetActive (true);
			Corazon2.SetActive (false);
		}
		if (ValorVida == 2) {
			Corazon2.SetActive (true);
			Corazon3.SetActive (false);
		}
		if (ValorVida == 3) {
			Corazon3.SetActive (true);
		}
	}
}
