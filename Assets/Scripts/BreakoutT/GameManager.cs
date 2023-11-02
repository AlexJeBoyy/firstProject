using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int lives = 3;

    public void LosseHealth()//if you lose ... health you lose
    {

        lives --;

        if (lives == 0)
        {
            SceneManager.LoadScene("BLose");
        }
        else
        {
            ResetLevel();
        }

    }

    public void ResetLevel()//if the ball goes to the bottom restets location of ball and player
    {
        FindObjectOfType<BallBreak>().ResetBall();
        FindObjectOfType<Player>().ResetPlayer();
    }
    public void CheckLevelCompleted()//checks if level is completed, so yes loads scene
    {
        Debug.Log(transform.childCount);
        if (transform.childCount == 1)
        {
            SceneManager.LoadScene("BWon");
        }
    }

}
