using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractOnTrigger : MonoBehaviour
{
    Text message;
    public bool triggerable;
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
        if (triggerable && !Pause.paused) {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Keypad0))
            {
                isInteracting = true;
                message.enabled = false;
                gameObject.GetComponent<AudioSource>().PlayOneShot(gameObject.GetComponent<AudioSource>().clip);
                GameObject.Find("demogorgon").GetComponent<MonsterController>().ChasePlayer();
                GameObject.Find("demogorgon").GetComponent<AudioSource>().Pause();
                GameObject.Find("demogorgon").GetComponent<AudioSource>().PlayOneShot(GameObject.Find("demogorgon").GetComponent<MonsterController>().growl);
                GameObject.Find("demogorgon").GetComponent<AudioSource>().Play();
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                GameObject.Find("Safe").GetComponent<Passcode_input>().Reset();
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
