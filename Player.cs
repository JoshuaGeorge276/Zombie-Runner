using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject spawnPointsParent;
    public bool spawnFlag = false;
    public GameObject landingArea;

    private Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
        spawnPoints = spawnPointsParent.GetComponentsInChildren<Transform>();
        Respawn();
	}
	
	// Update is called once per frame
	void Update () {
        if (spawnFlag) {
            Respawn();
            spawnFlag = false;
        }
	}

    private void Respawn() {
        int randomIndex = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[randomIndex].position;
    }

    private void OnFindClearArea() {
        Invoke("DropFlare", 3f);
    }

    private void DropFlare() {
        Instantiate(landingArea, transform.position, Quaternion.identity);
    }
}
