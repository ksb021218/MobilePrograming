using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elseif : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int distance = 30;

        if (distance > 100)
        {
            Debug.Log("�� �Ÿ��Դϴ�.");
        }
        else if (distance > 50) {
            Debug.Log("������ �Ÿ��Դϴ�.");
        }
        else
        {
            Debug.Log("����� �Ÿ��Դϴ�.");
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
