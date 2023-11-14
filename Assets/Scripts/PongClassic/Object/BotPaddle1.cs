using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class BotPaddle1 : MonoBehaviour
{
    public float ySpeed = 3f;
    private float yPosition = 0;
    public Vector3 posBall;
    public Vector3 posPlayer;
    public GameObject ball;
    public GameObject player;
    float ballYPostition = 0;
    float playerYPosition = 0;
   

    // Start is called before the first frame update
    void Start()
    {
        //ball = GameObject.Find("Ball");
        //player = GameObject.Find("RobotPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        //posBall = ball.transform.position;
        //posPlayer = player.transform.position;
        //ballYPostition = posBall.y;
        //playerYPosition = posPlayer.y;
        //if (playerYPosition < ballYPostition)
        //{

        //}
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
        if (yPosition >= 3.6f)
        {
            ySpeed = ySpeed * -1f;
        }
        else if (yPosition <= -3.6f)
        {
            ySpeed = ySpeed * -1f;
        }
        transform.position = new Vector3(transform.position.x, ball.transform.position.y / ySpeed, transform.position.z);
    }





}
