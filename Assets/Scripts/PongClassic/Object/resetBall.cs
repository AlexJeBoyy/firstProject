using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class resetBall : MonoBehaviour
{

    public GameObject ballObject;
    // Start is called before the first frame update
    void Start()
    {
        ballObject = GameObject.FindGameObjectWithTag("pongBall");
    }
    
    // Update is called once per frame
    void Update()
    { }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "verticalWallR")
        {
            ballObject.GetComponent<collision>().yPos = 0;
            ballObject.GetComponent<collision>().xPos = 0;
            
        }
        else if (collision.gameObject.name == "verticalWallL")
        {
            ballObject.GetComponent<collision>().yPos = 0;
            ballObject.GetComponent<collision>().xPos = 0;
        }

    }
}



