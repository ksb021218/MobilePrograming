using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ifelse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int love = 50;
        
        if(love > 70)
        {
            Debug.Log("�¿���: �����ΰ� ��Ͱ� �Ǿ���!");
        }
        else
        {
            Debug.Log("��忣��: �����ο��� ������.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
