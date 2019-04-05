using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLoadScreen : MonoBehaviour
{
    public bool HideCursor = false;
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    void Update() {
        if (HideCursor) {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
