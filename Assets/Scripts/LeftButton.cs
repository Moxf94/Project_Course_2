using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftButton : MonoBehaviour
{
    bool isPressed;
    public float speed = 500f;
    

    void Start()
    {
    }


    void Update()
    {
        if (isPressed)
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }

    }

 public void StartRo()
    {
        isPressed = true;
       
    }
   
    public void FinishRo()
    {
        isPressed = false;
    }
}
  

