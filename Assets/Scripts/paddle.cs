using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    
    //set the speed for your padles
    public float speed = 3.0f;
    public string leftOrRight;
    public float maxValue = 3.8f;
    void paddleControl(KeyCode up,KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y < maxValue)
        {
            Debug.Log("pressed w");
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue)
        {
            Debug.Log("pressed s");
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }


    // Update is called once per frame
    void Update()
    {


        //getkey works when you keep pressing it getkeydown oly workse once a tap
        if (leftOrRight == "left")
        {

            paddleControl(KeyCode.W, KeyCode.S);
        }else if (leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
