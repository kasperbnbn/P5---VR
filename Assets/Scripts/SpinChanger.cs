using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinChanger : MonoBehaviour
{
    [SerializeField] private SpinActivator yAxis;
    [SerializeField] private SpinActivatorX xAxis;
    [SerializeField] private List<SpinSettings> settings;
    private int index;

    private void Awake()
    {
        SpinSettings temp = new SpinSettings();
        temp.yDegreesToTurn = yAxis.degreesToTurn;
        temp.xDegreesToTurn = xAxis.degreesToTurn;
        temp.ySecondsForOneRotation = yAxis.secondsForOneRotation;
        temp.xSecondsForOneRotation = xAxis.secondsForOneRotation;
        settings.Add(temp);

        index = 0;
    }

    public void ChangeSettings()
    {
        yAxis.degreesToTurn = settings[index].yDegreesToTurn;
        xAxis.degreesToTurn = settings[index].xDegreesToTurn;
        yAxis.secondsForOneRotation = settings[index].ySecondsForOneRotation;
        xAxis.secondsForOneRotation = settings[index].xSecondsForOneRotation;
        index++;
        if (index >= settings.Count)
           index = 0;        
    }
}

[System.Serializable]
public class SpinSettings
{
    public float yDegreesToTurn;
    public float ySecondsForOneRotation;
    public float xDegreesToTurn;
    public float xSecondsForOneRotation;
}