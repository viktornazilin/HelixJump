using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Platform CurrentPlatform;

    public Game Game;
    public MenuController MenuController;

    public void ReachFinish()
    {
        Game.OnPlayerReachFinish();
        Rigidbody.velocity = Vector3.zero;
        MenuController.YouWin();
    }

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0,BounceSpeed, 0);
    }

    public void Die()
    {
        Game.OnPlayedDied();
        Rigidbody.velocity = Vector3.zero;
        MenuController.YouLose();
        
    }
}
