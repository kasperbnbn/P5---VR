using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinActivator : MonoBehaviour
{
    public KeyCode key;
    private float time = 0.1f;
    public float degreesToTurn;
    private Quaternion startRot;
    float r;
    bool started = false;
    private float speed = 6;//Takes 360 seconds for a full rotation at speed == 1. 60 seconds is speed == 6
    public float secondsForOneRotation = 60;
    private float movement;

    public Transform parentTransform;

    private void Awake()
    {
        startRot = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            started = true;
        }
        if (started)
        {
            StartSpin();
            if (movement < degreesToTurn)
            {
                movement += speed * (60/secondsForOneRotation) * Time.deltaTime;
            }
        }
    }

    private void StartSpin()
    {
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, startRot.eulerAngles.y + movement, ref r, time);
        this.transform.rotation = Quaternion.Euler(parentTransform.eulerAngles.x, angle, parentTransform.eulerAngles.z);
    }
}
