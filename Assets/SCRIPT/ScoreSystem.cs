using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    private int playerOneScore = 0;
    private int playerTwoScore = 0;

    public TextMeshProUGUI playerOneScoreText;
    public TextMeshProUGUI playerTwoScoreText;

    public void PlayerOneGoal()
    {
        playerOneScore++;
        playerOneScoreText.text = playerOneScore.ToString();
    }

    public void PlayerTwoGoal()
    {
        playerTwoScore++;
        playerTwoScoreText.text = playerTwoScore.ToString();
    }
}
