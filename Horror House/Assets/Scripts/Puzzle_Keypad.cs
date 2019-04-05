using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle_Keypad : MonoBehaviour
{
    InteractOnTrigger puzzle;
    Canvas keypad;
    HideCursor cursor;
    Camera_Control xCamera;
    Camera_Control yCamera;
    AudioSource heartbeat;
    
    void Start() {
        puzzle = GetComponent<InteractOnTrigger>(); 
        keypad = GameObject.Find("Keypad").GetComponent<Canvas>(); 
        cursor = GameObject.Find("Player").GetComponent<HideCursor>();
        xCamera = GameObject.Find("Player").GetComponent<Camera_Control>();
        yCamera = GameObject.Find("Main Camera").GetComponent<Camera_Control>();
        heartbeat = GameObject.Find("Player").GetComponent<AudioSource>();
    }
    void Update() {
        if (puzzle.isInteracting) {
            keypad.enabled = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            cursor.enabled = false;
            xCamera.enabled = false;
            yCamera.enabled = false;
            GameObject.Find("Player").GetComponent<Player_movement>().enabled = false;
            // Mute certain sounds
            GameObject.Find("Boiler").GetComponent<AudioSource>().Pause();
            GameObject.Find("Light bulb").GetComponent<AudioSource>().Pause();
            GameObject.Find("Outside Light").GetComponent<AudioSource>().Pause();
            // Enable heartbeat
            if (!heartbeat.isPlaying) heartbeat.Play();
        }
        else if (!puzzle.isInteracting && !Pause.paused){
            keypad.enabled = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            cursor.enabled = true;
            xCamera.enabled = true;
            yCamera.enabled = true;
            GameObject.Find("Player").GetComponent<Player_movement>().enabled = true;
            // Unmute
            GameObject.Find("Boiler").GetComponent<AudioSource>().UnPause();
            GameObject.Find("Light bulb").GetComponent<AudioSource>().UnPause();
            GameObject.Find("Outside Light").GetComponent<AudioSource>().UnPause();
            heartbeat.Stop();
        }
    }    
}
