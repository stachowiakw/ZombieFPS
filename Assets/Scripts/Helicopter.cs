using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
    bool HeliCalled;
    public TerrainScaner terrainScaner;

    // Use this for initialization
    void Start() {
        HeliCalled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("HeliCall"))
        {
            if (HeliCalled == false && terrainScaner.IsSpaceToLand() == true)
            { HeliInbound(); }
            else
            { HeliInboundFailed(); }
        }
    }

    void HeliInbound()
        {
            HeliCalled = true;
            print("Helicopter called");
        }

    void HeliInboundFailed()
        {
            print("Helicopter calling FAILED");
        }
    
}
