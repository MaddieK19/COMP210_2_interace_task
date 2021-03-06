﻿using UnityEngine;
using System.Collections;

public class Falcon_Controller : MonoBehaviour
{
    public GameObject falcon;
    public GameObject controller;
    public SerialController serialController;
    public GameObject flightPath;
    public SteamVR_TrackedController trackedController;

    public float speed;
    public bool collisionHappened = false;
    public bool isIdle = true;
    private float step;

    // Use this for initialization
    void Start()
    {
       falcon.transform.position = flightPath.transform.position;
       //serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleControllerInput(); 
        UpdatePosition();
    }

    void UpdatePosition()
    {
        if (isIdle)
        {
            falcon.transform.position = flightPath.transform.position;
            falcon.transform.LookAt(new Vector3 (flightPath.transform.position.x, flightPath.transform.position.y, flightPath.transform.position.z + 1));
        }

        if (collisionHappened == false && !isIdle)
        {
            float step = speed * Time.deltaTime;
            falcon.transform.position = Vector3.MoveTowards(transform.position, controller.transform.position, step);
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
        falcon.GetComponent<Animation>().CrossFade("FA_IdleLand");
        //serialController.SendSerialMessage("p");
        collisionHappened = true;
        isIdle = false;
    }

    void HandleControllerInput()
    {
        if (trackedController.triggerPressed)
        {
            Debug.Log("Right trigger pressed");
            isIdle = false;
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_IdleLand");

        }
        if (trackedController.gripped)
        {
            Debug.Log("Grip pressed");
            isIdle = true;
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_IdleFly");

        }
    }
}
