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
    public void LoadBreakoutlvl1()
    {
        SceneManager.LoadScene("BOlvl1");
    }
    public void LoadBreakoutlvl2()
    {
        SceneManager.LoadScene("BOlvl2");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
