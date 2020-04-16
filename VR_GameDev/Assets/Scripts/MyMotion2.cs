﻿using UnityEngine;
using System.Collections;
using UnityEngine.XR;

public class MyMotion2 : MonoBehaviour
{
    [SerializeField] private float m_RenderScale = 1f;
    CharacterController characterController;
    Transform camera;
    public bool prevLookingForward = false, lookingForward = false,
    isMoving = false;
    bool toggleForwardMotion, startLookingForward;
    public float speed = 1.0f;
    float toggleAngle = 30.0f;
 
    void Start()
    {
        XRSettings.eyeTextureResolutionScale = m_RenderScale;
        camera = GameObject.Find("Main Camera").transform;
        characterController = GetComponent<CharacterController>();
        camera.transform.Rotate(0, 30, 0);
    }

    void Update()
    {
        prevLookingForward = lookingForward;
        if (camera.transform.eulerAngles.x >= 15 &&
        camera.transform.eulerAngles.x < 100)
            lookingForward = false;
        else
            lookingForward = true;
        if (lookingForward == true && prevLookingForward == false)
 
    startLookingForward = true;
else
startLookingForward = false;
        if (startLookingForward)
            toggleForwardMotion = !toggleForwardMotion;
        if (lookingForward && toggleForwardMotion)
            isMoving = true;
        else
            isMoving = false;
        if (isMoving)
        {
            Vector3 forward = camera.TransformDirection(Vector3.forward);
            characterController.SimpleMove(forward * speed);
        }
    }
}