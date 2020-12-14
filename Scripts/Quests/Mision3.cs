using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mision3 : MonoBehaviour {
	public float distancia;
	public GameObject ActionDisplay;
	public GameObject TreasureChest;
	public GameObject ActionText;
	public GameObject TakeSword;
	public GameObject TheObjective;
	public GameObject nObjetivo;
	public int CloseObjective;

	void Update () {
		distancia = PlayerCast.DistanceFromTarget;
		if (CloseObjective == 1) {
			if (TheObjective.transform.localScale.y <= 0.0f) {
				CloseObjective = 0;
				TheObjective.SetActive (false);

			} else {
				TheObjective.transform.localScale -= new Vector3 (0.0f, 0.01f, 0.0f);
			}
		}
	}
	void OnMouseOver(){
		if (distancia <= 3) {
			ActionText.GetComponent<Text> ().text = "Abrir Cofre";
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}
		if (Input.GetButtonDown ("Action")) {
			if (distancia <= 3) {
				this.GetComponent<BoxCollider> ().enabled = false;
				TreasureChest.GetComponent<Animation> ().Play ("New Animation");
				TakeSword.SetActive (true);
				CloseObjective = 3;
				ActionText.SetActive (false);
				ActionDisplay.SetActive (false);
			}
		}
	}
	void OnMouseExit(){
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
		

}
