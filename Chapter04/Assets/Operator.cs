using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int age = 23;

        if(age > 7 && age < 18)
        {
            Debug.Log("�ǹ� ������ �ް� �ֽ��ϴ�.");
        }
        else
        {
            Debug.Log("�ǹ� ������ �ް� ���� �ʽ��ϴ�.");
        }
        if (age < 13 || age > 70)
        {
            Debug.Log("���� �� �� ���� �����Դϴ�.");
        }
        else
        {
            Debug.Log("���� �� �� ���� �����Դϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
