using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultySelect : MonoBehaviour
{
    public GameObject data;
    public Image star;

    public void SetEasy() {
        DifficultySetting.difficulty = 1;
        star.GetComponent<RectTransform>().anchoredPosition = new Vector3(148.6f, 4f, 131.0389f);
    }
    public void SetMedium() {
        DifficultySetting.difficulty = 2;
        star.GetComponent<RectTransform>().anchoredPosition = new Vector3(148.6f, -18.5f, 131.0389f);
    }
    public void SetHard() {
        DifficultySetting.difficulty = 3;
        star.GetComponent<RectTransform>().anchoredPosition = new Vector3(148.6f, -42f, 131.0389f);
    }
}
