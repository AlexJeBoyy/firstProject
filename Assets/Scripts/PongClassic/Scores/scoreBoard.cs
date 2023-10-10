using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreBoard : MonoBehaviour
{
    //public float lScore;
    //public float rScore;


    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.name == "verticalWallR")
        {
            ScoreManager.instance.SubPointL();
            //Debug.Log($"Left player score: {lScore}");
        }
        if (collision.gameObject.name == "verticalWallL")
        {
            ScoreManager.instance.SubPointR();
            //Debug.Log($"Right player score: {rScore}");
        }
    }
}
