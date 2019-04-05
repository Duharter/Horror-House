using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySet : MonoBehaviour
{
    public GameObject monster;
    public GameObject monster_light;
    int difficulty;

    void Start() {

        // Get data
        difficulty = DifficultySetting.difficulty;
        monster.GetComponent<UnityEngine.AI.NavMeshAgent>();

        // Set difficulty
        switch(difficulty) {
            case 1:
                GameObject.Find("Light bulb").GetComponent<LightFlicker>().time_light = 250;
                monster.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 1.0f;
                monster_light.GetComponent<Light>().enabled = true;
                monster_light.GetComponent<Light>().intensity = 1.5f;
                break;
            case 2:
                GameObject.Find("Light bulb").GetComponent<LightFlicker>().time_light = 200;
                monster.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 1.0f;
                monster_light.GetComponent<Light>().enabled = false;
                monster_light.GetComponent<Light>().intensity = 0.5f;
                break;
            case 3:
                GameObject.Find("Light bulb").GetComponent<LightFlicker>().time_light = 150;
                monster.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 1.25f;
                monster_light.GetComponent<Light>().enabled = false;
                monster_light.GetComponent<Light>().intensity = 0f;
                break;
        }
    }
}
