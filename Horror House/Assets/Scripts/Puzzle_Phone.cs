using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle_Phone : MonoBehaviour
{
    public GameObject monster;
    InteractOnTrigger puzzle;
    AudioSource source;
    public AudioClip pickup;
    public AudioClip message;
    public AudioClip aftersound;
    bool begin = false;

    int phone_cd = 100;
    bool play_once_0 = true;
    bool play_once_1 = true;
    bool play_once_2 = true;
    bool play_once_3 = true;
    bool play_once_4 = true;
    bool play_once_5 = true;
    bool play_once_6 = true;
    public int countdown = 50;
    bool begin_cd = false;
    
    void Start() {
        puzzle = GetComponent<InteractOnTrigger>(); 
        source = GetComponent<AudioSource>(); 
    }
    void Update() {
        // Starting game
        phone_cd--;
        if (phone_cd <= 0 && play_once_0) {
            source.Play();
            phone_cd = 0;
            play_once_0 = false;
        }

        // Interact sequence
        if (puzzle.isInteracting) {
            begin = true;
            source.Stop();
            puzzle.Disable();
            GameObject.Find("Obj1").GetComponent<Text>().text = "[X] Answer the phone";
        }
        if (begin) {
            if (play_once_1) {
                source.PlayOneShot(pickup);
                play_once_1 = false;
            }
            if (play_once_2 && !source.isPlaying && !play_once_1) {
                source.PlayOneShot(message);
                play_once_2 = false;
                begin_cd = true;
            }
        }
        if (begin_cd && play_once_3) {
            countdown--;
            if (countdown <= 0 && !source.isPlaying && !play_once_2) {
                source.PlayOneShot(aftersound);
                play_once_3 = false;
                countdown = 100;
            }
        }
        if (!source.isPlaying && !play_once_3 && play_once_4) {
            GameObject.Find("HUD").GetComponent<HUD_overlay>().PlayObjSFX();
            GameObject.Find("Obj2").GetComponent<Text>().enabled = true;

            // Enable stuff
            GameObject.Find("Outside Light").GetComponent<Lightning>().enabled = true;
            GameObject.Find("Bookshelf").GetComponent<SphereCollider>().enabled = true;
            GameObject.Find("trashbag").GetComponent<SphereCollider>().enabled = true;
            GameObject.Find("barrel").GetComponent<SphereCollider>().enabled = true;
            GameObject.Find("Wardrobe").GetComponent<SphereCollider>().enabled = true;
            play_once_4 = false;
            begin_cd = true;
        }
        // Play door squeak
        if (begin_cd && play_once_5 && !source.isPlaying && !play_once_4) {
            countdown--;
            if (countdown <= 0) {
                GameObject.Find("Door").GetComponent<AudioSource>().Play();
                play_once_5 = false;
            }
        }
        // Spawn demogorgon
        if (play_once_6 && !GameObject.Find("Door").GetComponent<AudioSource>().isPlaying && !play_once_5) {
            monster.SetActive(true);
            play_once_6 = false;
        }
    }   
}
