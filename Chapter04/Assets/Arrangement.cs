using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrangement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ������ �迭 ���� �� �ʱ�ȭ
        int[] intArray = new int[5];

        // �迭 ��ҿ� �� �Ҵ�
        intArray[0] = 10;
        intArray[1] = 20;
        intArray[2] = 30;
        intArray[3] = 40;
        intArray[4] = 50;

        // �迭 ��� ���
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
