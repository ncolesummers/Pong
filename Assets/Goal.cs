using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Goal class is used to detect when the ball enters the goal
/// </summary>
public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    /// <summary>
    /// This method is called when the ball enters the goal. It increments the score of the player who scored
    /// </summary>
    /// <param name="collision"> The collider of the object that entered the goal </param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Escape if the object that entered the goal is not the ball
        if (!collision.CompareTag("Ball")) return;
        if (!isPlayer1Goal)
        {
            Debug.Log("Score Player 1");
            GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
        }
        else
        {
            Debug.Log("Score Player 2");
            GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
        }
    }
    
}

