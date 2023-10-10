using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public static paddle instance;


    //set the speed for your padles
    public float ogSpeed;
    public float speed = 3.0f;
    public string leftOrRight;
    public float maxValue = 3.8f;

    
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        ogSpeed = speed;
    }

    public void ResetPaddleSpeed()
    {
        speed = ogSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pongBall"))
        {
            speed = speed * 1.1f;
        }
        else if (collision.gameObject.CompareTag("verticalWall"))
        {

        }
    }
    void paddleControl(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y < maxValue)
        {
            //Debug.Log("pressed w");
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue)
        {
            //Debug.Log("pressed s");
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }


    // Update is called once per frame
    void Update()
    {
        //getkey works when you keep pressing it getkeydown only workse once a tap
        if (leftOrRight == "left")
        {

            paddleControl(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
