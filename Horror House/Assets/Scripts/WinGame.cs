using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    InteractOnTrigger puzzle;
    public bool hasKey = false;

    void Start() {
        puzzle = GetComponent<InteractOnTrigger>(); 
    }
    void Update() {
        if (puzzle.isInteracting && hasKey) {
            puzzle.Disable();
            Debug.Log("You win");
        }
    }    
    public void Unlock() {
        hasKey = true;
    }
}
