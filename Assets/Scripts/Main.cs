using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Main : MonoBehaviour
{
    /// <summary>
    /// Create a delegate of type void that calculates the sum of two numbers. use a lambda to avoid having a dedicated Method
    /// </summary>


    //public Func<int, int, int> Sum;
    //private void Start()
    //{
    //    Sum = (num1, num2) => (num1 + num2);
    //}

    public Action<int, int> Sum;

    StringBuilder sb = new StringBuilder();

    private void Start()
    {
        //Sum = CalculateSum;

        Sum = (a, b) => {
            var totall = a + b;
            if (totall < 100)
            {
                Debug.Log("Total is less than 100");
            }
            sb.Append("Total: ");
            sb.Append(totall);
            Debug.Log(sb.ToString());
        };

        Sum(5, 2);
    }



}
