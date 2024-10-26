using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using Unity.XR;
using UnityEngine;

public class PlayerPlacer : MonoBehaviour
{
    public Transform player;
    public Transform sitPos;
    private CharacterController cc;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    void Update()
    {
        Vector3 posDiff = player.position - sitPos.position;

        if(posDiff.magnitude > 0)
        {
            cc.Move(-posDiff);
        }
    }

}
