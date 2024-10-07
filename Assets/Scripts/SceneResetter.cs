using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneResetter : MonoBehaviour
{
    public InputActionProperty rightGrip;
    public InputActionProperty leftGrip;
    public InputActionProperty rightPinch;
    public InputActionProperty leftPinch;
    private float timer = 0f;

    private void Update()
    {
        float r1Value = rightGrip.action.ReadValue<float>();
        float r2Value = rightPinch.action.ReadValue<float>();
        float l1Value = leftGrip.action.ReadValue<float>();
        float l2Value = leftPinch.action.ReadValue<float>();

        if(r1Value + r2Value + l1Value + l2Value == 4)
        {
            timer += Time.deltaTime;
            if(timer > 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else { timer = 0f; }
    }
}
