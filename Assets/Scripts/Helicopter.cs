using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
    bool HeliCalled;

	// Use this for initialization
	void Start () {
        HeliCalled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("HeliCall")) { if (HeliCalled == false) { HeliInbound(); } }
    }

    void HeliInbound()
    {
        HeliCalled = true;
        print("Helicopter called");
    }
}
