using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// EVENTS
public class Main : MonoBehaviour
{
    // A program using delegates and events where you hit the space key and assign a cube a position
    // of (5, 2, 0) -- The Cube script should subscribe to the event and be invoked when you hit the space key

    Input inputActions;

    // Deklaracija tipa S PARAMETROM
    public delegate void Teleport(Vector3 pos);
    public static event Teleport onTeleport;

    private void Awake()
    {
        inputActions = new Input();
        inputActions.BasicActions.SpaceActivation.performed += ctx => SpaceActivation_performed();
    }

    private void SpaceActivation_performed()
    {
        // Postavljanje FIKSNE varijable
        Vector3 pos = new Vector3(5, 2, 0);
        onTeleport?.Invoke(pos);
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}