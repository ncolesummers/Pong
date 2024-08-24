using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Paddle class is used to control the paddles in the game. It allows the player to move the paddles up and down.
/// </summary>
public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    private float _movement;
    
    /// <summary>
    /// Start is called before the first frame update. Saves the starting position of the paddle.
    /// </summary>
    void Start()
    {
        startPosition = transform.position;
    }

    /// <summary>
    /// Update is called once per frame. Moves the paddle up and down based on player input.
    /// </summary>
    void Update()
    {
        // Set the movement to the input of the player
        // Allows two players to play on the same keyboard
        if (isPlayer1)
        {
            _movement = Input.GetAxis("Vertical");
        }
        else
        {
            _movement = Input.GetAxis("Vertical2");
        }

        rb.velocity = new Vector2(0, _movement * speed);
        
    }
    
    /// <summary>
    /// Resets the paddle to the starting position
    /// </summary>
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
