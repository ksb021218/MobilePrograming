using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrangement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 정수형 배열 선언 및 초기화
        int[] intArray = new int[5];

        // 배열 요소에 값 할당
        intArray[0] = 10;
        intArray[1] = 20;
        intArray[2] = 30;
        intArray[3] = 40;
        intArray[4] = 50;

        // 배열 요소 출력
        Debug.Log("Array elements:");
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log("Element " + i + ": " + intArray[i]);
        }
}

// Update is called once per frame
void Update()
    {
        
    }
}
