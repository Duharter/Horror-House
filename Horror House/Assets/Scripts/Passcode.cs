using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Passcode : MonoBehaviour
{
    string passcode = "45545";
    Passcode_input input;
    int currKey;
    Text keyvalue;

    void Start() {
        keyvalue = this.gameObject.transform.GetChild(0).GetComponent<Text>();
    }
    void Update() {
        input = GameObject.Find("Safe").GetComponent<Passcode_input>();
        currKey = input.currKey;
    }

    public void CheckPress() {
        if (!input.GetDone()) {
            if (keyvalue.text[0] == passcode[currKey]) {
                if (currKey == passcode.Length - 1) {
                    this.gameObject.GetComponent<AudioSource>().enabled = false;
                    GameObject.Find("Safe").GetComponent<AudioSource>().clip =  GameObject.Find("Safe").GetComponent<Passcode_input>().correct;
                    GameObject.Find("Safe").GetComponent<AudioSource>().Play();
                    input.Finish();
                    Terminate();
                }
                input.Inc();
            }
            else {
                this.gameObject.GetComponent<AudioSource>().enabled = false;
                GameObject.Find("Safe").GetComponent<AudioSource>().Play();
                this.gameObject.GetComponent<AudioSource>().enabled = true;
                input.Reset();
            }
        }
    }
    void Terminate() {
        GameObject.Find("Safe").GetComponent<InteractOnTrigger>().isInteracting = false;
        GameObject.Find("Safe").GetComponent<InteractOnTrigger>().triggerable = false;
        GameObject.Find("Safe").GetComponent<SphereCollider>().enabled = false;
    }
}
