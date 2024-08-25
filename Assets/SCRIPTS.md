# Scripts

This document provides an overview of the scripts used in the Pong Unity game project. Each script is briefly described along with its role in the game.

## Ball

The [Ball](Ball.cs) script controls the behavior of the ball object in the game. It handles the launching of the ball, and resets the position of the ball when a goal is scored.

## GameManager

The [GameManager](GameManager.cs) script manages the game state, including the score tracking, game over conditions, and resetting the game.

## Goal

The [Goal](Goal.cs) script detects when the ball enters a goal area and notifies the GameManager to update the score.

## Help

The [Help](Help.cs) script displays the help menu when the player presses the "H" key during gameplay.

## Paddle

The [Paddle](Paddle.cs) script controls the movement of the paddles based on player input. It also handles the starting position of the paddles.
