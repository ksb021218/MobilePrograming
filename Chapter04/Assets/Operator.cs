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
            Debug.Log("의무 교육을 받고 있습니다.");
        }
        else
        {
            Debug.Log("의무 교육을 받고 있지 않습니다.");
        }
        if (age < 13 || age > 70)
        {
            Debug.Log("일을 할 수 없는 나이입니다.");
        }
        else
        {
            Debug.Log("일을 할 수 없는 나이입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
