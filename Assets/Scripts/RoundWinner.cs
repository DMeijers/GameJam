using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundWinner : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;
    public float timer = 240.0f;

    void Start()
    {
        Invoke("DetermineWinner", timer);
    }

    void DetermineWinner()
    {
        //these scores are fixed for testing
        //we need to add a way to retrieve the scores from the played round and assign them to the lines below
        player1Score = 10;
        player2Score = 20;

        Time.timeScale = 0;

        if (player1Score > player2Score)
        {
            Debug.Log("Player 1 wins");
        }
        else if (player1Score < player2Score)
        {
            Debug.Log("Player 2 wins");
        }
        else
        {
            Debug.Log("It's a tie");
        }
    }
}
