using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    public string name;
    public string sound;

    public void PlaySound()
    {
        Debug.Log(name + " : " + sound);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
