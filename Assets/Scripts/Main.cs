using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// EVENTS
public class Main : MonoBehaviour
{
    // DEKLARACIJA TIPA
    public delegate void ActionClick();
    // STVARANJE VARIJABLE TIPA EVENT
    public static event ActionClick onClick;

    // GETS CALLED FROM GUI BUTTON CLICK
    public void ButtonClick()
    {
        onClick?.Invoke();
        // same as above
        //if (onClick != null)
        //{
        //    onClick();
        //}
    }
}