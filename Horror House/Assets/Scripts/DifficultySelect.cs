using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelect : MonoBehaviour
{
    public GameObject data;

    public void SetEasy() {
        DifficultySetting.difficulty = 1;
    }
    public void SetMedium() {
        DifficultySetting.difficulty = 2;
    }
    public void SetHard() {
        DifficultySetting.difficulty = 3;
    }
}
