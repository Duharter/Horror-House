using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerMessage : MonoBehaviour
{
    public Text message;
    void OnTriggerEnter (Collider col) {
        if (col.gameObject.name == "Player")
        {
            message.enabled = true;
        }
    }
    void OnTriggerExit() {
        message.enabled = false;
    }
}
