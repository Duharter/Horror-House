using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool paused = false;
    GameObject player;
    GameObject camera;
    AudioSource[] audio;
    void Start() {
        player = GameObject.Find("Player");
        camera = GameObject.Find("Main Camera");
        audio = GameObject.FindSceneObjectsOfType(typeof(AudioSource)) as AudioSource[];
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!paused) {
                // Disable stuff
                player.GetComponent<Camera_Control>().enabled = false;
                player.GetComponent<Player_movement>().enabled = false;
                camera.GetComponent<Camera_Control>().enabled = false;
                // Disable monster
                // Disable timer
                // Disable light
                // Disable thunder
                // Disable objectives
                foreach(AudioSource audioSource in audio) {
                    audioSource.Pause();
                }

                
                paused = true;
                // TODO: show pause canvas
            }
            else {
                paused = false;player.GetComponent<Camera_Control>().enabled = true;
                player.GetComponent<Player_movement>().enabled = true;
                camera.GetComponent<Camera_Control>().enabled = true;
                // Enable monster
                // Enable timer
                // Enable light
                // Enable thunder
                // Enable objectives
                foreach(AudioSource audioSource in audio) {
                    audioSource.UnPause();
                }
            }
        }
    }
}
