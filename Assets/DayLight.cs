using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayLight : MonoBehaviour {
    private float newX, oldY, oldZ;
    public float timelapse;
    // Use this for initialization

    void Start () {
        newX = gameObject.transform.rotation.x;
        oldY = gameObject.transform.rotation.y;
        oldZ = gameObject.transform.rotation.z;
        timelapse = 1;
    }

    // Update is called once per frame
    void Update()
    {
        newX = timelapse*Time.deltaTime;
        gameObject.transform.Rotate(newX, 0, 0);
    }
}
