﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    Light source;
    float startingIntensity;
    int timeInterval = 500;
    public int currTimer;
    void Start() {
        currTimer = timeInterval;
        source = GetComponent<Light>();
        source.enabled = false;
        startingIntensity = source.intensity;
    }
    void Update() {
        currTimer--;
        if (currTimer <= 0) {
            source.enabled = true;
            source.intensity -= 0.5f;
        }
        if (source.intensity <= 0) {
            source.enabled = false;
            source.intensity = startingIntensity;
            currTimer = timeInterval;
        }
    }
}
