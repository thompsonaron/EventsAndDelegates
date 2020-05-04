using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Main : MonoBehaviour
{
    /// <summary>
    /// Create a delegate of type void that has no parameters and returns the gameObjects name
    /// </summary>


    public Action onGetName;

    private void Start()
    {
        // Short w/o StringBuilder
        //onGetName = () => Debug.Log("Name: " + gameObject.name);
        // W StringBuilder
        onGetName = () =>
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: ");
            sb.Append(gameObject.name);
            Debug.Log(sb.ToString());
        };

        onGetName?.Invoke();
    }
}
