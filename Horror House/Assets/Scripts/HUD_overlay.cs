using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_overlay : MonoBehaviour
{
    AudioSource source;
    public AudioClip objective;
    int timer = 50;
    public int currTimer;

    // First objective variables
    int obj_ctr = 200;
    bool play_once = true;

    void Start() {
        source = GetComponent<AudioSource>();
        currTimer = timer;
        currTimer = obj_ctr;
    }
    void Update() {
        // Show up first objective
        if (GameObject.Find("Phone").GetComponent<AudioSource>().isPlaying) {
            obj_ctr--;
        }
        if (obj_ctr <= 0 && play_once) {
            // Enable stuff
            GameObject.Find("Player").GetComponent<Player_movement>().enabled = true;
            GameObject.Find("Safe").GetComponent<Puzzle_Keypad>().enabled = true;

            // Show objective
            PlayObjSFX();
            GameObject.Find("Obj1").GetComponent<Text>().enabled = true;
            obj_ctr = 0;
            play_once = false;
        }
    }
    public void PlayObjSFX() {
        source.PlayOneShot(objective);

    }

    

}
