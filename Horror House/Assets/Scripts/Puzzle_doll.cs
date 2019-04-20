using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle_doll : MonoBehaviour
{
    InteractOnTrigger doll;
    public GameObject monster;
    
    void Start() {
        doll = GetComponent<InteractOnTrigger>(); 
    }
    void Update() {
        if (doll.isInteracting) {
            doll.Disable();
            monster.SetActive(true);
        }
    }    
}
