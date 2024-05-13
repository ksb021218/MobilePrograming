using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrangment2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[,] matrix = new string[,] { { "A", "B", "C" }, { "D", "E", "F" }, 
            { "G", "H", "I" } };

        Debug.Log("Matrix elements:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log("Element at (" + i + ", " + j + "): " + matrix[i, j]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
