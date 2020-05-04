using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void OnDeath();
    public static event OnDeath onDeath;

    Input inputActions;

    private void Awake()
    {
        inputActions = new Input();
        inputActions.BasicActions.SpaceActivation.performed += ctx => SpaceActivation_performed();
    }

    private void SpaceActivation_performed()
    {
        Death();
    }

    private void OnEnable() { inputActions.Enable(); }

    private void OnDisable() { inputActions.Disable(); }

    void Death()
    {
        onDeath?.Invoke();
        //OLD
        //if (onDeath != null)
        //{
        //    onDeath();
        //}
    }
}
