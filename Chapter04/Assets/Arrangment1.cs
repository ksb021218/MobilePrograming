using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrangment1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        Debug.Log("Numbers in the array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
