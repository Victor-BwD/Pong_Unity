using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text player1ScoreText, player2ScoreText; //variables to store a text from UI
    [HideInInspector] public int player1Score, player2Score; //variable to store the value himself

    
    public void IncreasePlayer1Score() //call from ball script
    {
        player1Score++; //increment
        player1ScoreText.text = player1Score.ToString(); //transform to string the value incremented
    }

    public void IncreasePlayer2Score() //call from ball script
    {
        player2Score++; //increment
        player2ScoreText.text = player2Score.ToString(); //transform to string the value incremented
    }
}
