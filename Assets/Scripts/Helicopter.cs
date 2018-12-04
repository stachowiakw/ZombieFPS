using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
    bool HeliCalled;
    public TerrainScaner terrainScaner;
    private Rigidbody heliRigidBody;

    // Use this for initialization
    void Start() {
        HeliCalled = false;
        heliRigidBody = GetComponent<Rigidbody>();
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
            heliRigidBody.velocity = new Vector3(0, 0, -50f);
            print("Helicopter called");
        }

    void HeliInboundFailed()
        {
            print("Helicopter calling FAILED");
        }
    
}
