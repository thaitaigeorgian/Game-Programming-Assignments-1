using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{

    void Start()
    {
        // Test the Multiply function
        double product = Multiply(5, 4);
        print($"Product of 5 and 4: {product}");

        // Test the Divide function
        double quotient = Divide(10.0, 2.0);
        print($"Quotient of 10.0 and 2.0: {quotient}");

        // Test the FindLowestNumber function
        double[] numbers = { 3.2, 7.5, 1.1, 9.9 };
        double lowest = FindLowestNumber(numbers);
        print($"Lowest number in the array: {lowest}");
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        return a / b;
    }

    public double FindLowestNumber(double[] numbers)
    {

        double lowest = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            double num = numbers[i];
            if (num < lowest)
            {
                lowest = num;
            }
        }
        return lowest;
    }
}