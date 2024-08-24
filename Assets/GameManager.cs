using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// The GameManager class is used to manage the game state and keep track of the score
/// </summary>
public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject player1Text;
    public GameObject player2Text;

    private int _player1Score;
    private int _player2Score;
    private const string Winner = "Winner! :-)";
    private const string Loser = "Loser! :-(";
    private const int MaxScore = 5;

    /// <summary>
    /// Called when player 1 scores a goal. Increments the score and resets the ball and paddles.
    /// </summary>
    public void Player1Scored()
    {
        _player1Score++;
        if (_player1Score == MaxScore)
        {
            player1Text.GetComponent<TextMeshProUGUI>().text = Winner;
            player2Text.GetComponent<TextMeshProUGUI>().text = Loser;
            Time.timeScale = 0;
            return;
        }
        player1Text.GetComponent<TextMeshProUGUI>().text = _player1Score.ToString();
        ResetPosition();
    }

    /// <summary>
    /// Called when player 2 scores a goal. Increments the score and resets the ball and paddles.
    /// </summary>
    public void Player2Scored()
    {
        _player2Score++;
        if (_player2Score == MaxScore)
        {
            player1Text.GetComponent<TextMeshProUGUI>().text = Loser;
            player2Text.GetComponent<TextMeshProUGUI>().text = Winner;
            Time.timeScale = 0;
            return;
        }
        player2Text.GetComponent<TextMeshProUGUI>().text = _player2Score.ToString();
        ResetPosition();
    }
    
    /// <summary>
    /// Resets the position of the ball and paddles.
    /// </summary>
    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
    
    /// <summary>
    /// Update is called once per frame. Quits the application when the escape key is pressed.
    /// </summary>
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
