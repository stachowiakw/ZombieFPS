﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

    private Camera eyes;
    private float defaultFOV;

	// Use this for initialization
	void Start () {
        eyes = GetComponent<Camera>();
        defaultFOV = 90;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("ViewZoom")) { eyes.fieldOfView = defaultFOV / 1.5f; }
        else { eyes.fieldOfView = defaultFOV; }
    }

    
}
