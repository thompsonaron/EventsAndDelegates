using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // create a program that takes in a string and returns the length of it (how many characters)
    //public delegate int CharacterLength(string text);

    // passing string value, returning int value
    public Func<string, int> CharacterLength;

    void Start()
    {
        CharacterLength = GetCharacters;

        int count = CharacterLength("Johnny");
        Debug.Log(count);
    }
    
    int GetCharacters(string name)
    {
        return name.Length;
    }

}
