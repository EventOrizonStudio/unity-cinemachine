﻿using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
//https://forum.unity.com/threads/how-to-change-aim-and-body-via-script.692248/
//better use 2 VCam rather than only one an changing body from script (bad idea)

public class SkyToFPS : MonoBehaviour {
    [SerializeField] private CinemachineVirtualCamera cineCam;
    [SerializeField] private CinemachineVirtualCamera cineSkyCam;
    [SerializeField] private Transform skyPos;
    [SerializeField] private Transform targetPos;

    [SerializeField] private bool skyMode;

    // Start is called before the first frame update
    void Start () {
        cineCam.enabled = !skyMode;
        cineSkyCam.enabled = skyMode;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.M)) {
            skyMode = !skyMode;
            Debug.Log ("switch cam Mode " + skyMode);
            //cineCam.Follow = skyMode ? skyPos : targetPos; //bad ideo (only one cam)

            cineCam.enabled = !skyMode;
            cineSkyCam.enabled = skyMode;

            //cineCam.GetCinemachineComponent<CinemachineTransposer>()
        }
    }
}