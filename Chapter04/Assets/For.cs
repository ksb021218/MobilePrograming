using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i + " 번째 순번입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
