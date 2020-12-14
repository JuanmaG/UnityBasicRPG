using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mision1_Botones : MonoBehaviour {
	public GameObject ThePlayer;
	public GameObject NoticeCam;
	public GameObject UIQuest;
	public GameObject ActiveQuestBox;
	public GameObject Objective01;

	public void AcceptQuest () {
		ThePlayer.SetActive (true);
		NoticeCam.SetActive (false);
		UIQuest.SetActive (false);
		StartCoroutine (SetQuestUI ());
	}

	IEnumerator SetQuestUI() {
		ActiveQuestBox.GetComponent<Text> ().text = "My First Weapon";
		Objective01.GetComponent<Text> ().text = "Reach the clearing in the wood";
		yield return new WaitForSeconds (0.5f);
		ActiveQuestBox.SetActive (true);
		yield return new WaitForSeconds (1);
		Objective01.SetActive (true);
		yield return new WaitForSeconds (9);
		ActiveQuestBox.SetActive (false);
		Objective01.SetActive (false);
	}

	public void DeclineQuest() {
		ThePlayer.SetActive (true);
		NoticeCam.SetActive (false);
		UIQuest.SetActive (false);
	}

}
