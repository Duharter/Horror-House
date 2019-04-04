using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    Camera mainCam;
    Camera hideCam;

    public int rayLength = 10;

    void Start()
    {
        mainCam.enabled = true;
        hideCam.enabled = false;
    }

    private void Update()
    {
        RaycastHit hit;
       // int fwd = transform.TransformDirection(Vector3.forward);
    }
}

