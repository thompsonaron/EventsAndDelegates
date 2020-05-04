using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//needed for action
using System;

public class Player : MonoBehaviour
{
    //public delegate void OnDamageReceived(int currentHealth);
    //public static event OnDamageReceived onDamage;

    // same as above event and its delegate
    public static Action<int> OnDamageReceived;
    // void example
    //public Action onDamage;



    public int health;
    Input inputActions;

    private void Awake()
    {
        inputActions = new Input();
        inputActions.BasicActions.SpaceActivation.performed += ctx => SpaceActivation_performed();
    }

    private void Start()
    {
        health = 10;
    }

    private void SpaceActivation_performed()
    {
        Damage();
    }

    private void OnEnable() { inputActions.Enable(); }

    private void OnDisable() { inputActions.Disable(); }

    void Damage()
    {
        health--;

        OnDamageReceived?.Invoke(health);
    }
}
