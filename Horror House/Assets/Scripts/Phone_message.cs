using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Phone_message : MonoBehaviour
{
    InteractOnTrigger phone;
    public AudioSource source;
    bool play_once = true;
    
    void Start() {
        phone = GetComponent<InteractOnTrigger>(); 
    }
    void Update() {
        if (phone.isInteracting && play_once) {
            source.PlayOneShot(source.clip);
            play_once = false;
            phone.Disable();
        }
    }    
}
