﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle_paper : MonoBehaviour
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
            GameObject.Find("Obj2").GetComponent<Text>().text = "[X] Get the 1st code from the bookshelf";
            loadNextObj = true;
        }
        if (loadNextObj) {
            obj_cd--;
            if (obj_cd <= 0 && play_once) {
                GameObject.Find("first").GetComponent<Text>().enabled = true;
                GameObject.Find("HUD").GetComponent<HUD_overlay>().PlayObjSFX();
                GameObject.Find("Obj3").GetComponent<Text>().enabled = true;
                GameObject.Find("Safe").GetComponent<Puzzle_Keypad>().enabled = true;
                GameObject.Find("Wardrobe").GetComponent<SphereCollider>().enabled = true;
                obj_cd = 0;
                play_once = false;
            }
        }
    }    
}
