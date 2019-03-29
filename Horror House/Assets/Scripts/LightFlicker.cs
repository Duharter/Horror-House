using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    // Objects
    public Light spotLight;
    public Light pointLight;
    float spotLight_intensity;
    float pointLight_intensity;

    // Timers
    public int timer_activation = 50;
    int currTimer;
    public int delayBetweenFlickers = 2;
    int dyn_delayBetweenFlickers;
    public int flicker_count = 5;
    public int flicker_delay = 10;

    // States
    bool flicker = false;
    bool wait = false;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize timers
        currTimer = timer_activation;
        dyn_delayBetweenFlickers = delayBetweenFlickers;   

        // Settings
        spotLight_intensity = spotLight.intensity;
        pointLight_intensity = pointLight.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        if (!flicker) {
            if (currTimer != 0) {
                currTimer--;
            }
            else {
                flicker = true;
            }
        }
        updateLight();
    }

    void updateLight() {
        if (flicker) {
            flicker_delay--;
            if (flicker_delay <= 0) {
                flicker_count--;
                wait = true;
                flickerLight();
                if (!wait) {
                    flicker_delay = 10;
                }
            }
        }
        if (flicker_count == 0) {
            flicker = false;
            currTimer = timer_activation;
            flicker_count = 5;
        }
    }


    void flickerLight() {
    dyn_delayBetweenFlickers--;
        spotLight.intensity = spotLight_intensity;
        pointLight.intensity = pointLight_intensity;
        if (dyn_delayBetweenFlickers <= 0) {
            spotLight.intensity = 0;
            pointLight.intensity = 0;
            wait = false;
            dyn_delayBetweenFlickers = delayBetweenFlickers;
        }
    }
}
