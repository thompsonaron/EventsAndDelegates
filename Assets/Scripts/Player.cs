using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Input inputActions;

    private void Awake()
    {
        inputActions = new Input();
        inputActions.BasicActions.SpaceActivation.performed += ctx => SpaceActivation_performed();
    }

    private void SpaceActivation_performed()
    {

    }

    private void OnEnable() { inputActions.Enable(); }

    private void OnDisable() { inputActions.Disable(); }
}
