﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;        // The player's score.

    Text text;                      // Reference to the Text component.


    void Start()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        score = GameControl.control.playerscore;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + GameControl.control.playerscore;

        //if (GameControl.control.playerscore >= threshold)
        //{
        //    GameControl.control.bossbattle = true;
        //}
    }
}