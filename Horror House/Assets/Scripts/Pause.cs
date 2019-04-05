using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    static public bool paused = false;
    GameObject player;
    GameObject camera;
    public GameObject monster;
    public GameObject canvas;
    AudioSource[] audio;
    float monsterSpeed;
    void Start() {
        player = GameObject.Find("Player");
        camera = GameObject.Find("Main Camera");
        audio = GameObject.FindSceneObjectsOfType(typeof(AudioSource)) as AudioSource[];
        monsterSpeed = monster.GetComponent<UnityEngine.AI.NavMeshAgent>().speed;
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
                if (monster.activeInHierarchy) {
                    monster.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 0;
                    //monster.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                    //monster.GetComponent<MonsterController>().enabled = false;
                }
                foreach(AudioSource audioSource in audio) {
                    audioSource.Pause();
                }

                // Enable dark screen
                canvas.SetActive(true);
                
                paused = true;
            }
            else {
                player.GetComponent<Camera_Control>().enabled = true;
                player.GetComponent<Player_movement>().enabled = true;
                camera.GetComponent<Camera_Control>().enabled = true;
                if (monster.activeInHierarchy) {
                    monster.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = monsterSpeed;
                    //monster.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
                    //monster.GetComponent<MonsterController>().enabled = true;
                }
                foreach(AudioSource audioSource in audio) {
                    audioSource.UnPause();
                }

                // Disable dark screen
                canvas.SetActive(false);

                paused = false;
            }
        }
    }
}
