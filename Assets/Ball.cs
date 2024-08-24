using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// Script for the ball in the game. Used to launch the ball in a random direction
/// </summary>
public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    /// <summary>
    /// Resets the ball to the starting position and launches it
    /// </summary>
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }
    
    /// <summary>
    /// This method launches the ball in a random direction
    /// </summary>
    private void Launch()
    {
        // Randomize the direction of the ball
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
