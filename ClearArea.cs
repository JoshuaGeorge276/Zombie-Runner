using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

    public float timeSinceLastTrigger = 0f;

    private bool foundClearArea = false;

    private void Update() {
        timeSinceLastTrigger += Time.deltaTime;
        if(timeSinceLastTrigger > 2f && Time.realtimeSinceStartup > 10f && !foundClearArea) {
            foundClearArea = true;
            SendMessageUpwards("OnFindClearArea");
        }
    }

    private void OnTriggerStay(Collider other) {
        
        if(other.gameObject != this.transform.parent.gameObject) {
            Debug.Log(other.gameObject);
            timeSinceLastTrigger = 0f;
        } 
    }
}
