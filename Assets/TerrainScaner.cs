using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScaner : MonoBehaviour
{
    public float timer;
    // Use this for initialization
    void Start()
    {
        timer = 0;
    }

    private void Update()
    {
        timer = timer + Time.deltaTime;
    }

    private void OnTriggerStay()
    {
        timer = 0;
        print("dotykamCzegos!");
    }

    public bool IsSpaceToLand()
    {
        if (timer>1) { return true; }
        else { return false; }
    }
}