using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// DELEGATES
public class Main : MonoBehaviour
{
    // DEKLARACIJA TIP
    public delegate void ChangeColor(Color newColor);
    // DEKLARACIJA VARIJABLE
    public ChangeColor onColorChange;

    // DEKLALRACIJA TIPA
    public delegate void OnComplete();
    // DEKLARACIJA VARIJABLE
    public OnComplete onComplete;

    private void Start()
    {
        // POSTAVLJANJE VARIJABLE
        onColorChange = UpdateColor;
        onColorChange(Color.green);
        // DODAVANJE U VARIJABLU, NESTO SLICNO LISTI
        onComplete += Task;
        onComplete += Task2;
        onComplete += Task3;
        onComplete -= Task;

        // AKTIVIRANJE VARIJABLE I PROVJERA JE LI NULL
        onComplete?.Invoke();
        // SAME AS ABOVE
        //if (onComplete != null)
        //{
        //    onComplete();   
        //}
    }

    public void UpdateColor(Color newColor)
    {
        Debug.Log("Changing color to: " + newColor.ToString());
    }

    public void Task()
    {
        Debug.Log("Task 1 Finished");
    }
    public void Task2()
    {
        Debug.Log("Task 2 Finished");
    }
    public void Task3()
    {
        Debug.Log("Task 3 Finished");
    }
}
