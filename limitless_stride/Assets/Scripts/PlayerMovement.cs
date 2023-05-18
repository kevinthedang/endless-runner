/**
 * Author(s): Kevin Dang
 * Date: 5-17-2023
 * File: PlayerMovement.cs
 * Desc: Player Movement Class to handle the movement for a player and other 
 *          related things that a player might have.
 *       
 * Last Modified: 5-17-2023
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Player Settings
    private int SetHealth { get; set; }      // set player health
    #endregion

    #region Player Fields
    private bool HasCollided { get; set; }      // check if the player has collided with something that might hurt them
    private int PlayerHealth { get; set; }        // player health represented as an integer
    private float PlayerScore { get; set; }     // current score for the player
    #endregion

    /// <summary>
    /// Initialize Fields for Player once set, or run defaults for now
    /// </summary>
    private void Awake()
    {
        // default health settings --> 3 health, possibly allow user to change number of lives (between 1-5?)
        SetHealth = 3;

        // initialize Player status from configuration
        PlayerHealth = SetHealth;
        HasCollided = false;
    }

    /// <summary>
    /// Once initialized to the scene, update the current interface with 
    ///     the appropriate information the user needs to see
    /// </summary>
    private void Start()
    {
        // Set up interface for player
        // ...

        // first update to the interface with information?
    }

    /// <summary>
    /// Update Monobehavior method will be used to check the following:
    ///     1. Player Movement
    ///     2. Player Health
    ///     3. The Current Score
    /// </summary>
    private void Update()
    {
        // things to check per frame
        // check for collision, what the collision was, then call methods as appropriate (REFER TO onCollisionEnter)
        if (HasCollided) // update condition to reflect collision to check or make a method that returns a bool
            UpdateHealth();
        else
            UpdateScore();
    }

    /// <summary>
    /// Method call to change the player configuration for the game
    /// </summary>
    /// <param name="newHealth">new desired player health for game</param>
    public void UpdateSettings(int newHealth)
    {
        SetHealth = newHealth;
    }

    /// <summary>
    /// Private Player method to update player health as needed
    /// </summary>
    private void UpdateHealth()
    {
        // if user collides with "hostile" entity
        // then decrement health by 1, let UI know about changes
        // else do nothing with the health
    }

    private void UpdateScore()
    {
        // if user collides with "score" entity
        // then increment score by 1, let UI know about changes
        // else do nothing with score
    }
}
