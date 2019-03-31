using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    // Objects
    public Light spotLight;
    public Light pointLight;

    // Timers
    public int time_dark = 200;
    public int time_light = 150;
    public int currTimer;
    public int delayBetweenFlickers = 2;
    int dyn_delayBetweenFlickers;
    public int flicker_count = 5;
    public int flicker_delay = 10;
    int flicker_count_priv;
    int flicker_delay_priv;

    // States
    bool dark = false;
    bool pause = false; // lock for dark <-> light

    // Start is called before the first frame update
    void Start()
    {
        // Initialize timers
        currTimer = time_light;
        dyn_delayBetweenFlickers = delayBetweenFlickers;   
        flicker_count_priv = flicker_count;
        flicker_delay_priv = flicker_delay;
    }

    void Update() {
        currTimer--;
        if (currTimer <= 0) {
            Flicker();
            if (!pause) {
                flicker_count_priv = flicker_count;
                flicker_delay_priv = flicker_delay;
                UpdateLight();
            }
        }
    }

    void UpdateLight() {
        if (dark) {
            spotLight.enabled = true;
            pointLight.enabled = true;
            dark = false;
            currTimer = time_light;
        }
        else {
            spotLight.enabled = false;
            pointLight.enabled = false;
            dark = true;
            currTimer = time_dark;
        }
    }

    void Flicker() {
        pause = true;
        spotLight.enabled = false;
        pointLight.enabled = false;
        flicker_delay_priv--;
            
        if (flicker_delay_priv <= 0) {
            spotLight.enabled = true;
            pointLight.enabled = true;
            flicker_count_priv--;
            flicker_delay_priv = flicker_delay;
        }

        if (flicker_count_priv == 0) {
            pause = false;
        }
    }
}
