using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public Control Controls;
    public static int score;
    public TextMeshProUGUI scoreText;

    public enum State 
    {
        Playing,
        Won,
        Loss
    }

    public State CurrentState {get; private set; }

    public void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score; 
    }

    public void OnPlayedDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        Controls.enabled = false;
        Debug.Log("Game Over!");
    }

    public void OnPlayerReachFinish()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Won;
        Controls.enabled = false;
        Debug.Log("You won!"); 
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }


}
