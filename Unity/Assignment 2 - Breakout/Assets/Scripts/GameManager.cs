using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public int lives;
    public int highscore;
    private bool gameInPlay = false;
    private int level;

    ///////////////////////////////////////////////////////////////////////////
    /// 
    /// TODO: Declare a list of gameobjects for the bricks, as per the design
    /// - Make sure it is accessible from other classes
    /// 
    ///////////////////////////////////////////////////////////////////////////




    private GameObject ball;
    private GameObject bat;

    [SerializeField] GameObject brickPrefab;
    [SerializeField] GameObject batPrefab;
    [SerializeField] GameObject ballPrefab;
    [SerializeField] Text TextBoxScore;
    [SerializeField] Text TextBoxHighscore;
    [SerializeField] Text TextBoxTitle;
    [SerializeField] Text TextBoxNewHigh;
    [SerializeField] Text TextBoxPrompt;
    [SerializeField] Text TextBoxLives;

    void Start()
    {
        TextBoxNewHigh.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameInPlay)
        {
            // game over when you're out of lives
            if (lives <= 0)
            {
                EndGame();
            }
            // check for the last brick being destroyed, and start a new level
            if (bricks.Count == 0 && gameInPlay)
            {
                level++;
                StartNewLevel(level);
            }
        }
        else
        {
            // press Q to quit (will only work in standalone executable)
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
            }

            ///////////////////////////////////////////////////////////////////////////
            /// 
            /// TODO: Check if the player has pressed the 'P' key when at game over
            /// - Respond by calling the function to start a new game, 
            /// - and changing the appropriate variable so that the game is in play
            /// 
            ///////////////////////////////////////////////////////////////////////////

        }

        // keep on-screen values up to date
        TextBoxScore.text = "SCORE: " + score;
        TextBoxLives.text = "LIVES: " + lives;
        TextBoxHighscore.text = "HIGH: " + highscore;
    }

    private void StartNewGame()
    {
        score = 0;
        lives = 3;
        TextBoxLives.enabled = true;
        TextBoxTitle.enabled = false;
        TextBoxPrompt.enabled = false;
        TextBoxNewHigh.enabled = false;
        bat = Instantiate(batPrefab, new Vector3(0, -4, 0), Quaternion.identity);
        ball = Instantiate(ballPrefab, new Vector3(0, -2, 0), Quaternion.identity);
        level = 1;

        ///////////////////////////////////////////////////////////////////////////
        /// 
        /// TODO: Call the function to start a new level
        /// - Include appropriate arguments for parameters
        /// 
        ///////////////////////////////////////////////////////////////////////////


    }

    ///////////////////////////////////////////////////////////////////////////
    /// 
    /// TODO: Create the function to start a new level
    /// - Include appropriate parameters
    /// - Set the ball's co ordinates to 0, -2, 0
    /// - Give the player a bonus 10 points if it's level 2 or more
    /// - Use one or more FOR loops to iterate through 4 rows of 10 bricks
    /// - Each brick should be instantiated from the brick prefab
    /// - it's co-ordinates should be calculated so the bricks are in a grid
    /// - Add the new object created, into the list of bricks.
    /// 
    ///////////////////////////////////////////////////////////////////////////



    private void EndGame()
    {
        // Find out if we have a new highscore
        if (score > highscore)
        {
            highscore = score;
            TextBoxNewHigh.enabled = true;
        }

        // Remove all bricks from the game and from the list
        for (int i = bricks.Count - 1; i >= 0; i--)
        {
            Destroy(bricks[i]);
            bricks.RemoveAt(i);
        }
        Destroy(ball.gameObject);
        Destroy(bat.gameObject);
        TextBoxLives.enabled = false;
        TextBoxTitle.enabled = true;
        TextBoxPrompt.enabled = true;
        gameInPlay = false;
    }
}
