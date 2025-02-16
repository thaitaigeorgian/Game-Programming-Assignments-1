using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] list = { 10, 30, 90, 60, 70, 17, 5, 29, 49, 99, 98 };

        int minIndex = 0;
        int maxIndex = 0;
        int min = list[minIndex];
        int max = list[maxIndex];

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] < min)
            {
                minIndex = i;
                min = list[i];
            }

            if (list[i] > max)
            {
                maxIndex = i;
                max = list[i];
            }
        }


        print("Lowest: " + min);
        print("Lowest Index: " + minIndex);
        print("Highest: " + max);
        print("Highest Index: " + maxIndex);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
