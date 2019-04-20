using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintGeneraor : MonoBehaviour
{
    public Text hint;
    int hint_num = 0;
    void Start()
    {
        hint_num = Random.Range(0, 5);
        switch(hint_num) {
            case 0:
                hint.text = "Hint: The monster is attracted to sound.";
            break;
            case 1:
                hint.text = "Hint: Interacting with objects create sounds.";
            break;
            case 2:
                hint.text = "Hint: Listen carefully to your surroundings. If you feel you are in danger, run!";
            break;
            case 3:
                hint.text = "Hint: The monster can feel you if you are near it.";
            break;
            case 4:
                hint.text = "Hint: Do not panic! Take things slow and observe your surroundings.";
            break;
        }
    }
}
