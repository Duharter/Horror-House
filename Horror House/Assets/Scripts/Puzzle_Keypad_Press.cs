using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle_Keypad_Press : MonoBehaviour
{
    InteractOnTrigger puzzle;
    string passcode;
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
            if (keyvalue.text[0] == Puzzle_Passcode.passcode[currKey]) {
                if (currKey == Puzzle_Passcode.passcode.Length - 1) {
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
        GameObject.Find("Safe").GetComponent<InteractOnTrigger>().Disable();
        GameObject.Find("Obj4").GetComponent<Text>().text = "[X] Enter the code in the safe";
        GameObject.Find("Locked Door Msg").GetComponent<BoxCollider>().enabled = false;
        GameObject.Find("escape").GetComponent<Text>().enabled = true;
        GameObject.Find("escape").GetComponent<AudioSource>().Play();
        GameObject.Find("Exit").GetComponent<SphereCollider>().enabled = true;
        GameObject.Find("Exit").GetComponent<WinGame>().Unlock();
        GameObject.Find("Keypad").SetActive(false);

        // Chase player after he/she interacts
        GameObject.Find("demogorgon").GetComponent<MonsterController>().ChasePlayer();
    }
}
