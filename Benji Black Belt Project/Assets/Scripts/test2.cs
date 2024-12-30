using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    public GameObject sillius;
    public float silly2;
    
    // Start is called before the first frame update
    void Start()
    {
        silly2 = 8f;
        sillius.GetComponent<test>().myFunction();
        sillius.GetComponent<test>().function2(silly2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
