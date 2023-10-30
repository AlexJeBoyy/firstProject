using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public paddle paddle;
    

    //breakout for a good
    public float xPos = 0f;
    public float yPos = 0f;
    public float xSpeed = 3.0f;
    public float ySpeed = 3.0f;
    public float ogySpeed;
    public float ogxSpeed;

    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPos, yPos, 0f);
        ogxSpeed = xSpeed;
        ogySpeed = ySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        xPos += xSpeed * Time.deltaTime;
        //xPos = xPos + xSpeed x Time.deltaTime; does the same
        yPos += ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPos, yPos, 0f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            // Debug.Log("auw my hat or my feet");
            ySpeed = ySpeed * -1f;
        } else if (collision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1f;
            paddle.instance.ResetPaddleSpeed();// Reset paddle speed when the ball hits the vertical walls
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.05f;
            ySpeed = ySpeed * 1.025f;
        }


        if (collision.gameObject.name == "verticalWallR")
        {
            Vector3 newPosition = new Vector3(xPos + yPos, transform.position.y, transform.position.z);
            xSpeed = -ogxSpeed;
            ySpeed = -ogySpeed;
        }
        else if (collision.gameObject.name == "verticalWallL")
        {
            Vector3 newPosition = new Vector3(xPos + yPos, transform.position.y, transform.position.z);
            xSpeed = ogxSpeed;
            ySpeed = ogySpeed;
        }
    }
}
