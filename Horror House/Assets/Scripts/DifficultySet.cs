using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySet : MonoBehaviour
{
    public GameObject monster;
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
                GameObject.Find("Monster Light").GetComponent<Light>().enabled = true;
                GameObject.Find("Monster Light").GetComponent<Light>().intensity = 1.5f;
                break;
            case 2:
                GameObject.Find("Light bulb").GetComponent<LightFlicker>().time_light = 200;
                monster.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 1.25f;
                GameObject.Find("Monster Light").GetComponent<Light>().enabled = true;
                GameObject.Find("Monster Light").GetComponent<Light>().intensity = 1.25f;
                break;
            case 3:
                GameObject.Find("Light bulb").GetComponent<LightFlicker>().time_light = 150;
                monster.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 1.5f;
                GameObject.Find("Monster Light").GetComponent<Light>().enabled = false;
                GameObject.Find("Monster Light").GetComponent<Light>().intensity = 1f;
                break;
        }
    }
}
