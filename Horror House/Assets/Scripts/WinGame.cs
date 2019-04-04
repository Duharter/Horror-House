using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            
            // Win game
            GameObject.Find("Player").GetComponent<HideCursor>().enabled = false;
            GameObject.Find("Safe").GetComponent<Puzzle_Keypad>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }    
    public void Unlock() {
        hasKey = true;
    }
}
