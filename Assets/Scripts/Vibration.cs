using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Vibration : MonoBehaviour
{
    UnityEngine.XR.HapticCapabilities capabilitiesL;


    public void startVibra()
    {
        InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).TryGetHapticCapabilities(out capabilitiesL);
        InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetHapticCapabilities(out capabilitiesL);
        if (capabilitiesL.supportsImpulse)
        {
            uint channel = 0;
            float amplitude = 0.5f;
            float duration = 0.4f;
            InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).SendHapticImpulse(channel, amplitude, duration);
            InputDevices.GetDeviceAtXRNode(XRNode.RightHand).SendHapticImpulse(channel, amplitude, duration);
        }
    }
}
