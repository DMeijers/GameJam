using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI uiText;
    [SerializeField] private float mainTimer;

    

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;

    public TextMeshProUGUI RetreiveText;

    public int player1score;
    public int player2score;


    void Start()
    {
        timer = mainTimer;
       
    }


    void Update()
    {
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F");
        }

        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.0";
            timer = 0.0f;

            DetermineWinner();

        }

    }

    void DetermineWinner()
    {
        //these scores are fixed for testing
        //we need to add a way to retrieve the scores from the played round and assign them to the lines below
        GameObject player1Object = GameObject.Find("PlayerTree");
        GameObject player2Object = GameObject.Find("PlayerHuman");

        player1score = player1Object.GetComponent<ObjectSpawner>().objectCounter;
        player2score = player2Object.GetComponent<ObjectSpawnerHuman>().objectCounter;

        if (player1score > player2score)
        {
            RetreiveText.text = "Player 1 Wins!";
            Debug.Log("Player 1 wins");
        }
        else if (player1score < player2score)
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
