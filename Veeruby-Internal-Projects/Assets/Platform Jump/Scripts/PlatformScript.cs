using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{

    public float move_Speed = 2f;
    public float bound_Y = 6f;

    public bool moving_Platform_Left, moving_Platform_Right, breakable_Platform, spike_Platform, standerd_Platform;

    private Animator anim;


    public void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 temp = transform.position;
        temp.y += move_Speed * Time.deltaTime;
        transform.position = temp;

        if (temp.y >= bound_Y)
        {
            gameObject.SetActive(false);
        }
    }

    void BreakableDeactivate()
    {
        Invoke("DeactivateGameObject", 3f);
        SoundManager.instance.BreakClip();
    }

    void DeactivateGameObject()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        
        if (target.tag == "Player")
        {
            if (spike_Platform)
            {
                target.transform.position = new Vector2(1000f, 1000f);
                SoundManager.instance.GameOverClip();
                ManageGame.Instance.RestartGame();
               
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
       
        if (target.gameObject.tag == "Player")
        {
            if (breakable_Platform)
            {
                anim.Play("Breakable Platform");

            }

            if (standerd_Platform)
            {
                SoundManager.instance.LandClip();
            }
        }
    }


    private void OnCollisionStay2D(Collision2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            
            if (moving_Platform_Left)
            {
                target.gameObject.GetComponent<PlayerMovement>().PlatformMove(-1f);
            }
            if (moving_Platform_Right)
            {
                target.gameObject.GetComponent<PlayerMovement>().PlatformMove(1f);
            }

        }
    }
}
