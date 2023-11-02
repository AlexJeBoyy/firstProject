using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreTextR;
    public Text scoreTextL;


    public int scoreR = 5;
    public int scoreL = 5;
    public int winScore = 0;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update


    void Start()
    {
        scoreTextL.text = "♥" + scoreL.ToString();
        scoreTextR.text = "♥" + scoreR.ToString();
    }

    public void SubPointR()
    {
        scoreL -= 1;
        scoreTextL.text = "♥" + scoreL.ToString();
    }

    public void SubPointL()
    {
        scoreR -= 1;
        scoreTextR.text = "♥" + scoreR.ToString();
    }
    public void Update()
    {
        if (scoreR == 0)
        {
            SceneManager.LoadScene("LeftPlayerWon");
        }
        else if (scoreL == 0)
        {
            SceneManager.LoadScene("RightPlayerWon");
        }
    }
}

