using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string characterName = "���";
        char bloodType = 'B';
        int age = 23;
        float height = 199.9f;
        bool isFemale = true;

        Debug.Log("ĳ���� �̸� : " + characterName);
        Debug.Log("������ : " + bloodType);
        Debug.Log("���� : " + age);
        Debug.Log("Ű : " + height);
        Debug.Log("�����ΰ�? : " + isFemale);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
