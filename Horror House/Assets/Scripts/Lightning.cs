using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    Light source;
    float startingIntensity;
    public int timeInterval = 1000;
    public int currTimer;
    void Start() {
        currTimer = timeInterval;
        source = GetComponent<Light>();
        source.enabled = false;
        startingIntensity = source.intensity;
    }
    void Update() {
        if (!Pause.paused) 
            currTimer--;
        if (currTimer <= 0) {
            if (!GetComponent<AudioSource>().isPlaying) GetComponent<AudioSource>().Play();
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
