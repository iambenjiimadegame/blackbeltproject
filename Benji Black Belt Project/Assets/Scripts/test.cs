using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int myVariable = 100;
    // Start is called before the first frame update
    void Start()
    {
        print(myVariable);
        print("hello " + myVariable.ToString());
    }

    public int myFunction()
    {
        return 7;
    }

    public float function2(float silly)
    {
        return 7.8f + silly;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
