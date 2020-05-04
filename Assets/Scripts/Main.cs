using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Main : MonoBehaviour
{
    /// <summary>
    /// Create a delegate of type int that takes 2 numbers as a parameter and adds the sum
    /// </summary>

    //  first int is in (num1), second int is allso in (num2), third int is out (num1 + num2) in this case
    public Func<int, int, int> onCalcSum;

    private void Start()
    {
        // short
        //onCalcSum = (num1, num2) => num1 + num2;
        onCalcSum = (num1, num2) =>
        {
            // logic
            // logic
            // logic
            return num1 + num2;
        };

        int result = onCalcSum(3, 5);
        StringBuilder sb = new StringBuilder();
        sb.Append("Result: ");
        sb.Append(result);
        Debug.Log(sb.ToString());
    }

    // non lambda
    //int CalcSum(int a, int b)
    //{
    //    return a + b;
    //}
}
