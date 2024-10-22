using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using Unity.XR;
using UnityEngine;

public class PlayerPlacer : MonoBehaviour
{
    public Transform player;
    public Transform sitPos;
    void Update()
    {
        Vector3 posDiff = player.position - sitPos.position;

        if(posDiff.magnitude > 0)
        {
            player.Translate(-posDiff.x, -posDiff.y, -posDiff.z);
        }
    }

}
