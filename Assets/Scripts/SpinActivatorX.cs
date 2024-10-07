using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpinActivatorX : MonoBehaviour
{
    public KeyCode key;
    public float degreesToTurn;
    bool started = false;
    private float speed = 6;//Takes 360 seconds for a full rotation at speed == 1. 60 seconds is speed == 6
    public float secondsForOneRotation = 60;
    private float movement;

    public InputActionProperty activateButton;
    public InputActionProperty deactivateButton;
    float timer = 0f;

    void Update()
    {
        float activateValue = activateButton.action.ReadValue<float>();
        float deactivateValue = deactivateButton.action.ReadValue<float>();

        if (activateValue == 1 && deactivateValue == 0)
        {
            if (!started)
            {
                timer += Time.deltaTime;
                if (timer >= 1)
                {
                    started = true;
                }
            }

        }

        if (deactivateValue == 1)
        {
            if (started)
            {
                timer += Time.deltaTime;
                if(timer >= 0.5f)
                {
                    started = false;
                }
            }
        }

        if (deactivateValue == 0 && activateValue == 0)
        {
            timer = 0;
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
        this.transform.localRotation = Quaternion.AngleAxis(movement, Vector3.right);
    }
}
