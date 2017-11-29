using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    private Rigidbody rigidBody;
    private bool called;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}

    public void OnDispatchHelicopter() {
        Debug.Log("Helicopter Dispatched");
        rigidBody.velocity = new Vector3(0, 0, 50);
        called = true;
    }
}
