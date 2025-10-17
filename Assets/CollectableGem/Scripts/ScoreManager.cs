/*
David Huerta
2D Prototype
Tracks and displays player score.
*/

using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text winText;
    public int gemsToWin = 10;

    public bool playerWon = false;

    private int score = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        score = 0;                // score resets to 0 on scene load
        playerWon = false;        // clear win flag
        if (scoreText != null) scoreText.text = "Score: " + score;
        if (winText != null) winText.text = "";
    }

    public void AddScore(int points)
    {
        score += points;
        if (scoreText != null) scoreText.text = "Score: " + score;
    }

    public bool HasPlayerWon()
    {
        return score >= gemsToWin;
    }

    public void ShowWin()
    {
        playerWon = true;
        if (winText != null) winText.text = "You Win! Press R to Restart";
        Time.timeScale = 0f; // pause game
    }
}
