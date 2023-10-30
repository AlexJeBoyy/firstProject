using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public Rigidbody2D ribidBody2D;

    
    private float inputValue;
    public float moveSpeed = 25f;

    private Vector2 direction;

    void Update()
    {
        inputValue = Input.GetAxisRaw("Horizontal");

        if (inputValue == 1)
        {
            direction = Vector2.right;
        }
        else if (inputValue == -1) 
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.zero;
        }

        ribidBody2D.AddForce(direction * moveSpeed * Time.deltaTime * 100);

    }
}
