using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D myBody;

    private float moveSpeed = 3f;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    

    public void MoveRight()
    {
       
            myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);
        
    }

    public void MoveLeft()
    {
      
            myBody.velocity = new Vector2(-moveSpeed, myBody.velocity.y);
        
    }



    public void PlatformMove(float x)
    {
        myBody.velocity = new Vector2(x, myBody.velocity.y);
    }
}
