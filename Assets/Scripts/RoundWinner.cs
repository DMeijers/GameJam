using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoundWinner : MonoBehaviour
{
    public float timer = 20.0f;

    [SerializeField] ObjectSpawner player1score;
    [SerializeField] ObjectSpawnerHuman player2score;

    public Text RetreiveText;
    public Text TimerText;

    void Start()
    {
    
    }
    void DetermineWinner()
     {



       Time.timeScale = 1.0f;

       if (player1score.objectCounter > player2score.objectCounter)
         {
        RetreiveText.text = "Player 1 Wins!";
            Debug.Log("Player 1 wins");
      }
         else if (player1score.objectCounter < player2score.objectCounter)
         {
          RetreiveText.text = "Player 2 Wins!";
            Debug.Log("Player 2 wins");
        }
        else
       {
        RetreiveText.text = "It's a Tie!";
            Debug.Log("It's a Tie");
        }
     }
}
