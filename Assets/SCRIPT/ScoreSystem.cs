using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    private int playerOneScore = 0;
    private int playerTwoScore = 0;

    public Text playerOneScoreText;
    public Text PlayerTwoScoreText;

    public void PlayerOneGoal()
    {
        playerOneScore++;
        playerOneScoreText.text = playerOneScore.ToString();
    }

    public void PlayerTwoGoal()
    {
        playerTwoScore++;
        playerOneScoreText.text = playerTwoScore.ToString();
    }
}
