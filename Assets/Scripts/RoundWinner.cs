using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoundWinner : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;
    public float timer = 240.0f;
    
    public Text resultText;
   

    




void Start()
{
    
}

void Update()
{
    
    void DetermineWinner()
     {
    //these scores are fixed for testing
    //we need to add a way to retrieve the scores from the played round and assign them to the lines below
      player1Score = 10;
      player2Score = 20;

       Time.timeScale = 0;

       if (player1Score > player2Score)
         {
        resultText.text = "Player 1 Wins!";
      }
         else if (player1Score < player2Score)
         {
          resultText.text = "Player 2 Wins!";
      }
        else
       {
        resultText.text = "It's a Tie!";
       }
       }
}
