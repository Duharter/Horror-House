using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractOnTrigger : MonoBehaviour
{
    Text message;
    public bool triggerable;
    public int noise_level = 5;
    public bool isInteracting;
    SphereCollider collider;

    void Start() {
        message = GameObject.Find("msg_interact").GetComponent<Text>(); 
        collider = GetComponent<SphereCollider>();
    }
    void OnTriggerEnter (Collider col) {
        if (col.gameObject.name == "Player")
        {
            message.enabled = true;
            triggerable = true;
        }
    }
    void OnTriggerExit() {
        message.enabled = false;
        triggerable = false;
        isInteracting = false;
    }
    void Update() {
        if (triggerable) {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isInteracting = true;
                message.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                isInteracting = false;
                message.enabled = true;
            }
        }
    }
    public void Disable() {
        isInteracting = false;
        triggerable = false;
        collider.enabled = false;
    }
}
