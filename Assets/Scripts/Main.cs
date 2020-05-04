using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Main : MonoBehaviour
{
    /// <summary>
    /// Create a delegate of type int that returns the length of the gameObjects name
    /// </summary>

    public Func<int> onGetName;

    private void Start()
    {
        // NON LAMBDA
        //onGetName = GetName;
        onGetName = () => this.gameObject.name.Length;

        int charCount = onGetName();

        Debug.Log(charCount);
    }

    // FOR non lambda
    //int GetName()
    //{
    //    return this.gameObject.name.Length;
    //}
}
