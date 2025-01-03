using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Switch : MonoBehaviour
{
    public GameObject VersionOne;
    public GameObject VersionTwo;

    public bool switched = false;

    // Start is called before the first frame update
    void Start()
    {
        VersionOne.SetActive(true);
        VersionTwo.SetActive(false);
        switched = false;
}



    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Shift") && switched)
        {
            //VersionOne.SetActive(true);
            //VersionTwo.SetActive(false);
            //switched = false;
            //StartCoroutine(delay());
            //yield return new WaitForSecondsRealtime(3f);
            Invoke("changeLandscape1", 0.25f);
        }
        else if (Input.GetButton("Shift") && !switched)
        {
            //VersionOne.SetActive(false);
            //VersionTwo.SetActive(true);
            //switched = true;
            //StartCoroutine(delay());
            //yield return new WaitForSecondsRealtime(3f);
            Invoke("changeLandscape2", 0.25f);
        }

        
    }

    
    public void changeLandscape1()
    {
        
            VersionOne.SetActive(true);
            VersionTwo.SetActive(false);
            switched = false;
          
    }
    public void changeLandscape2()
    {
        
            VersionOne.SetActive(false);
            VersionTwo.SetActive(true);
            switched = true;
            
    }
}
