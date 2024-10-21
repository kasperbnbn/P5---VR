using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ControlManager : MonoBehaviour
{
    public Transform xAxis;
    public Transform yAxis;

    public InputActionProperty rightIndexButton;
    public UnityEvent rightIndexAction;
    public InputActionProperty leftIndexButton;
    public UnityEvent leftIndexAction;
    public InputActionProperty rightGripButton;
    public UnityEvent rightGripAction;
    public InputActionProperty leftGripButton;
    public UnityEvent leftGripAction;
    public InputActionProperty rightAButton;
    public UnityEvent rightAAction;
    public InputActionProperty rightBButton;
    public UnityEvent rightBAction;
    public InputActionProperty leftXButton;
    public UnityEvent leftXAction;
    public InputActionProperty leftYButton;
    public UnityEvent leftYAction;

    //public InputActionProperty[] inputActions;
    //public UnityEvent[] events;

    private void Update()
    {
        float rightActivateValue = rightIndexButton.action.ReadValue<float>();
        float leftActivateValue = leftIndexButton.action.ReadValue<float>();
        float rightGripValue = rightGripButton.action.ReadValue<float>();
        float leftGripValue = leftGripButton.action.ReadValue<float>();
        float rightAValue = rightAButton.action.ReadValue<float>();
        float rightBValue = rightBButton.action.ReadValue<float>();
        float leftXValue = leftXButton.action.ReadValue<float>();
        float leftYValue = leftYButton.action.ReadValue<float>();

        //for (int i = 0; i < inputActions.Length; i++)
        //{
        //    float value = inputActions[i].action.ReadValue<float>();
        //    CheckInput(value, events[i]);
        //}

        CheckInput(rightActivateValue, rightIndexAction);
        CheckInput(leftActivateValue, leftIndexAction);
        CheckInput(rightGripValue, rightGripAction);
        CheckInput(leftGripValue, leftGripAction);
        CheckInput(rightAValue, rightAAction);
        CheckInput(rightBValue, rightBAction);
        CheckInput(leftYValue, leftYAction);
        CheckInput(leftXValue, leftXAction);
    }

    private void CheckInput(float x, UnityEvent events)
    {
        if(x == 1f)
        {
            events.Invoke();
        }
    }
}
