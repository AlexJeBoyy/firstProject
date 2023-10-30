using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float xPos = 0f;
    public float yPos = -2f;
    public float xSpeed = 3.0f;
    public float ySpeed = -3.0f;
    public float ogySpeed;
    public float ogxSpeed;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPos, yPos, 0f);
        ogySpeed = ySpeed;
        ogxSpeed = xSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        xPos += xSpeed * Time.deltaTime;
        yPos += ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPos, yPos, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1f;
           
        }
        else if (collision.gameObject.CompareTag("Respawn"))
        {
            xPos = 0; 
            yPos = -1;
            
            ySpeed = ogySpeed;
            if (xSpeed < 0)
            {
                xSpeed *= 1f;
            }
            else if (xSpeed > 0)
            { 
                xSpeed *= 1f; 
            }

        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * 1f;
            ySpeed = ySpeed * -1f;
        }
        //else if (collision.gameObject.CompareTag("Player"))
        //{
        //    xSpeed = xSpeed;
        //    ySpeed = ySpeed;
        //}
    }
}
