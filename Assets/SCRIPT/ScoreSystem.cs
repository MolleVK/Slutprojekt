using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{
    public int WinScore;

    private int playerOneScore = 0;
    private int playerTwoScore = 0;

    public TextMeshProUGUI playerOneScoreText;
    public TextMeshProUGUI playerTwoScoreText;

    public void PlayerOneGoal()
    {
        playerOneScore++;
        playerOneScoreText.text = playerOneScore.ToString();
        CheckScore();
    }

    public void PlayerTwoGoal()
    {
        playerTwoScore++;
        playerTwoScoreText.text = playerTwoScore.ToString();
        CheckScore();
    }

    private void CheckScore()
    {
        if (playerOneScore == WinScore || playerTwoScore == WinScore)
        {
            SceneManager.LoadScene(2);
        }
    }
}
//Score systemet är också tagen från samma video som alla sprites kommer ifrån med andra ord 'https://www.youtube.com/watch?v=JZvNFrS7wTM'