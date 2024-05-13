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
            Debug.Log("먼 거리입니다.");
        }
        else if (distance > 50) {
            Debug.Log("적당한 거리입니다.");
        }
        else
        {
            Debug.Log("가까운 거리입니다.");
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
