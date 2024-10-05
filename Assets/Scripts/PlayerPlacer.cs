using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlacer : MonoBehaviour
{
    public Transform player;
    public Transform sitPos;
    void Start()
    {
        Debug.Log(player.position + " " + sitPos.position);
        player.position = sitPos.position;
        Debug.Log(player.position);
    }

}
