using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Main : MonoBehaviour
{
    /// <summary>
    /// Simple callback system - basically injecting code
    /// </summary>


    private void Start()
    {
        StartCoroutine(MyRoutine(() =>
        {
            Debug.Log("The routine has finished!");
            Debug.Log("Wow this is cool!");
        }));
    }

    // Action onComplete = null makes it (variable) optional
    private IEnumerator MyRoutine(Action onComplete = null)
    {
        yield return new WaitForSeconds(3.0f);

        onComplete?.Invoke();
    }
}
