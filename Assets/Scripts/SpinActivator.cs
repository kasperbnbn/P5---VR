using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

public class SpinActivator : MonoBehaviour
{
    public KeyCode key;
    public float degreesToTurn;
    bool started = false;
    private float speed = 6;//Takes 360 seconds for a full rotation at speed == 1. 60 seconds is speed == 6
    public float secondsForOneRotation = 60;
    private float movement;
    UnityEngine.XR.HapticCapabilities capabilitiesL;
    public InputActionProperty activateButton;
    public InputActionProperty deactivateButton;
    private Timer timer;

    private void Awake()
    {
        timer = new Timer();
    }

    void Update()
    {
        float activateValue = activateButton.action.ReadValue<float>();
        float deactivateValue = deactivateButton.action.ReadValue<float>();


        if (activateValue == 1 && deactivateValue == 0)
        {
            if (!started)
            {
                timer.StartTimer();
                if (timer.time >= 1)
                {
                    started = true;
                    Vibra();
                }
            }

        }

        if (deactivateValue == 1)
        {
            if (started)
            {
                timer.StartTimer();
                if (timer.time >= 0.5f)
                {
                    started = false;
                }
            }
        }

        if (deactivateValue == 0 && activateValue == 0)
        {
            timer.ResetTimer();
            timer.StopTimer();
        }

        if (started)
        {
       
            StartSpin();
            if (movement < degreesToTurn)
            {
                movement += speed * (60/secondsForOneRotation) * Time.deltaTime;
            }
            
        }
        timer.IncrementTime();
    }

    private void StartSpin()
    {
        this.transform.localRotation = Quaternion.AngleAxis(movement, Vector3.up);
       
    }

    private void Vibra()
    {
        InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetHapticCapabilities(out capabilitiesL);
        if (capabilitiesL.supportsImpulse)
        {
            uint channel = 0;
            float amplitude = 0.5f;
            float duration = 0.4f;

            InputDevices.GetDeviceAtXRNode(XRNode.RightHand).SendHapticImpulse(channel, amplitude, duration);
        }
    }
   
}
