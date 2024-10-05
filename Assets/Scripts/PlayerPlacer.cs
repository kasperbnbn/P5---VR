using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class PlayerPlacer : MonoBehaviour
{
    public Transform player;
    public Transform sitPos;
    void Start()
    {
        XROrigin xROrigin = new XROrigin();
        xROrigin.MoveCameraToWorldLocation(sitPos.position);
    }

}
