using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{
    public Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.AddForce(-500, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
