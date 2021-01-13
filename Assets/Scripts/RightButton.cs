using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour
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
            transform.Rotate(Vector3.back * speed * Time.deltaTime);
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

