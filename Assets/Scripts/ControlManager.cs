using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ControlManager : MonoBehaviour
{
    public Transform xAxis;
    public Transform yAxis;

    public InputActionProperty rightIndexButton;
    public InputActionProperty leftIndexButton;
    public InputActionProperty rightGripButton;
    public InputActionProperty leftGripButton;
    public InputActionProperty rightAButton;
    public InputActionProperty rightBButton;

    public UnityEvent rightIndexAction;
    public UnityEvent leftIndexAction;
    public UnityEvent rightAAction;
    public UnityEvent rightBAction;

    private void Update()
    {
        float rightActivateValue = rightIndexButton.action.ReadValue<float>();
        float leftActivateValue = leftIndexButton.action.ReadValue<float>();
        float rightAValue = rightAButton.action.ReadValue<float>();
        float rightBValue = rightBButton.action.ReadValue<float>();
        
        CheckInput(rightActivateValue, rightIndexAction);
        CheckInput(leftActivateValue, leftIndexAction);
        CheckInput(rightAValue, rightAAction);
        CheckInput(rightBValue, rightBAction);
    }

    private void CheckInput(float x, UnityEvent events)
    {
        if(x == 1f)
        {
            events.Invoke();
        }
    }
}
