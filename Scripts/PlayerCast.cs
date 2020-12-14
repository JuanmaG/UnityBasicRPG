using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCast : MonoBehaviour {

    public static float DistanceFromTarget;
    public float ToTarget;
    public AudioSource Banda;

    private void Start()
    {
        Banda.Play();
    }

    void Update () {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out Hit)) {
            ToTarget = Hit.distance;
            DistanceFromTarget = ToTarget;
        }
	}
}
