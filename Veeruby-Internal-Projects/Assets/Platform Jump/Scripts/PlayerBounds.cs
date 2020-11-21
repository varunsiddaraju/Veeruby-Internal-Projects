using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    public float X_BoundMax = 3f;
    public float X_BoundMin = -3f;
    public float Y_BoundMin = -7f;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckBounds();
    }

    private void CheckBounds()
    {
        Vector2 temp = transform.position;

        if(temp.x > X_BoundMax)
        {
            temp.x = X_BoundMax; Debug.Log("X");
        }
        

        if (temp.x < X_BoundMin)
        {
            temp.x = X_BoundMin; Debug.Log("Y");
        }
       

        transform.position = temp;


        if (temp.y <= Y_BoundMin)
        {
            Debug.Log("Out of bounds");
        }
    }
}
