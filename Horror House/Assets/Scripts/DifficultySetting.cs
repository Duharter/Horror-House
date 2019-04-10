using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySetting : MonoBehaviour
{
    
    static public int difficulty = 1;

    void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update() {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

   
}
