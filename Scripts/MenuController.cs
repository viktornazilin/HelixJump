using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    public static int SceneIndex = 2;

    public void Exit() 
    { 
        Application.Quit(); 
    } 
    public void YouLose()
    {
       SceneManager.LoadScene("Game Over Menu"); 
    }

    public void YouWin()
    {
        SceneManager.LoadScene("Win Menu");
        SceneIndex++;
    }

    public void Menu()
    {
        
        SceneManager.LoadScene("Start");
    }

    public void StartPlaying()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneIndex);

    }

    public void GoToLevel(int number)
    {
        SceneManager.LoadScene(number);
        SceneIndex = number;

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
 