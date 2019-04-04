﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    SphereCollider collider;

    void Start() {
        collider = GetComponent<SphereCollider>();
    }
    void OnTriggerEnter (Collider col) {
        if (col.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Death");
        }
    }
}
