using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    public float time;
    public bool started;

    public void StartTimer()
    {
        started = true;
    }
    public void StopTimer()
    {
        started = false;
    }
    public void ResetTimer()
    {
        time = 0f;
    }

    public void IncrementTime()
    {
        if (started)
        {
            time += Time.deltaTime;
        }
    }
}
