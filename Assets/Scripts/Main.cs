using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{


    // passing string value, returning int value
    public Func<string, int> CharacterLength;

    void Start()
    {
        // LAMBDA - passing in a parameter and "go to" line I guess?
        // it is same as a commented out method underneath
        // (name) is a parameter which I am sending and name.Length is what I am returning
        CharacterLength = (name) => name.Length;

        int count = CharacterLength("Jonneh Bravo");

        Debug.Log(count);
    }
    
    //int GetCharacters(string name)
    //{
    //    return name.Length;
    //}

}
