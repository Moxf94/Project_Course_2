using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
   // bool press;

    void Start()
    {

    }


    void Update()
    {
        
    }

    public void StartScene()
    {
        SceneManager.LoadScene(1);
        //print("Yes");
    }

}
