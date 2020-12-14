using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public static int NumeroMisionActiva;
	public int NumeroInternoMision;
	// Update is called once per frame
	void Update () {
		NumeroInternoMision = NumeroMisionActiva;
	}
}
