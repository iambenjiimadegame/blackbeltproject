using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goToLevelTest()
    {
        SceneManager.LoadScene(3);
    }

    public void goToHowToPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void goToCredits()
    {
        SceneManager.LoadScene(2);
    }
}
