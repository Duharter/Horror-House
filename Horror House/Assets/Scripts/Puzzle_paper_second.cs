using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle_paper_second : MonoBehaviour
{
    InteractOnTrigger puzzle;
    int obj_cd = 50;
    bool loadNextObj = false;
    bool play_once = true;
    
    void Start() {
        puzzle = GetComponent<InteractOnTrigger>(); 
    }
    void Update() {
        if (puzzle.isInteracting) {
            puzzle.Disable();
            GameObject.Find("Obj3").GetComponent<Text>().text = "[X] Get the 2nd code from the wardrobe";
            loadNextObj = true;
        }
        if (loadNextObj) {
            obj_cd--;
            if (obj_cd <= 0 && play_once) {
                GameObject.Find("second").GetComponent<Text>().enabled = true;
                GameObject.Find("HUD").GetComponent<HUD_overlay>().PlayObjSFX();
                GameObject.Find("Obj4").GetComponent<Text>().enabled = true;
                GameObject.Find("Safe").GetComponent<Puzzle_Keypad>().enabled = true;
                obj_cd = 0;
                play_once = false;
            }
        }
    }    
}
