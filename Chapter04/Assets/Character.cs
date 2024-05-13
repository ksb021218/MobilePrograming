using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string characterName = "라라";
        char bloodType = 'B';
        int age = 23;
        float height = 199.9f;
        bool isFemale = true;

        Debug.Log("캐릭터 이름 : " + characterName);
        Debug.Log("혈액형 : " + bloodType);
        Debug.Log("나이 : " + age);
        Debug.Log("키 : " + height);
        Debug.Log("여성인가? : " + isFemale);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
