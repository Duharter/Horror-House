using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passcode_input : MonoBehaviour
{
    public int currKey = 0;
    bool done = false;
    public AudioClip correct;
    public void Inc() {
        currKey++;
    }
    public void Reset() {
        currKey = 0;
    }
    public bool GetDone() {
        return done;
    }
    public void Finish() {
        done = true;
    }
}
