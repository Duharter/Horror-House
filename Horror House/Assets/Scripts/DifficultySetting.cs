using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySetting : MonoBehaviour
{
    
    static public int difficulty = 1;

    void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update() {
    }

   
}
