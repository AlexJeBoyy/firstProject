using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int lives = 3;

    public void LosseHealth()
    {

        lives --;

        if (lives <= 0)
        {
            SceneManager.LoadScene("BLose");
        }
        else
        {
            ResetLevel();
        }

    }

    public void ResetLevel()
    {
        FindObjectOfType<BallBreak>().ResetBall();
        FindObjectOfType<Player>().ResetPlayer();
    }


}
