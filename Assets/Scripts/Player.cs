using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    GameObject SpawnPointsParent;
    int NumberOfSpawnPoints;
    Transform[] SpawnPoint;
    public bool ReSpawned = true;

	// Use this for initialization
	void Start () {
        SpawnPointsParent = GameObject.Find("PlayerSpawnPoints");
        NumberOfSpawnPoints = SpawnPointsParent.transform.childCount;
        SpawnPoint = new Transform[NumberOfSpawnPoints];
        for (int i=0; i<NumberOfSpawnPoints; i++)
        {
            SpawnPoint[i] = SpawnPointsParent.transform.GetChild(i);
        }
        ReSpawn(Random.Range(0, NumberOfSpawnPoints));
    }
	
    void ReSpawn(int NumberOfSpawnPoint)
    {
        ReSpawned = true;
        gameObject.transform.position = SpawnPoint[NumberOfSpawnPoint].transform.position;
    }
    
	// Update is called once per frame
	void Update () {
		if (ReSpawned == false) { ReSpawn(Random.Range(0, NumberOfSpawnPoints)); }
	}
}
