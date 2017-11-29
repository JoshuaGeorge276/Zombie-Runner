using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioController : MonoBehaviour {

    public AudioClip initialHeliCall;
    public AudioClip initialCallReply;

    private AudioSource audio;

    private void Start() {
        audio = GetComponent<AudioSource>();
    }

    void OnMakeInitialHeliCall() {
        audio.clip = initialHeliCall;
        audio.Play();
        
        Invoke("CallReply", initialHeliCall.length + 1f);
        BroadcastMessage("OnDispatchHelicopter");
    }

    private void CallReply() {
        audio.clip = initialCallReply;
        audio.Play();
    }
}
