﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour {

    public Animation animation;


	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            animation.Play();
        }
        else {
        }
	}
}
