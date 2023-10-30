using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void LoadMultiPayer()
    {
        SceneManager.LoadScene("PongMultiPlayer");
    }
    public void LoadSinglePayer()
    {
        SceneManager.LoadScene("PongSinglePlayer");
    }
    public void LoadBreakout()
    {
        SceneManager.LoadScene("PongBreakout");
    }

}
