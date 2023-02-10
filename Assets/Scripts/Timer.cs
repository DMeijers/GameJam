using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // [SerializeField] public TextMeshProUGUI uiText;
    // [SerializeField] private float mainTimer;

    public bool TimerOn = false;
    public float TimeLeft;

    // private float timer;
    // private bool canCount = true;
    // private bool doOnce = false;

    public TextMeshProUGUI RetreiveText;

    public Text TimerTxt;

    public GameObject button;

    public ObjectSpawner player1;
    public ObjectSpawnerHuman player2;

    public int player1score;
    public int player2score;


    void Start()
    {
        // timer = mainTimer;

        // TimerOn = true;

    }
    public void StartTimer()
    {

        TimerOn = true;

    }

    
    public void ResetTheGame()
    {
        if (TimerOn == false)
        {
            AudioManager.Instance.play("start_3");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
    }


    void Update()
    {
        if (TimerOn)
        {

        
        if (TimeLeft > 0 )//&& canCount)
        {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
                // timer -= Time.deltaTime;
                // uiText.text = timer.ToString("F");
            }

            else  //if (timer <= 0.0f && !doOnce)
            {
                // canCount = false;
                //  doOnce = true;
                //  uiText.text = "0.0";
                // timer = 0.0f;

                DetermineWinner();
                TimerOn = false;
                TimeLeft = 0;
                button.GetComponent<ButtonV>().MakeButtonVisible();
                Debug.Log("Time is UP!!!");
                
            }
        
    }
}


    void updateTimer (float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }


    void DetermineWinner()
    {
        //these scores are fixed for testing
        //we need to add a way to retrieve the scores from the played round and assign them to the lines below


        GameObject player1Object = GameObject.FindGameObjectWithTag("Player 1");
        GameObject player2Object = GameObject.FindGameObjectWithTag("Player 2");


        player1score = player1.objectCounter;
        player2score = player2.objectCounter;
        //player1score = player1Object.GetComponent<ObjectSpawner>().objectCounter;
        //player2score = player2Object.GetComponent<ObjectSpawnerHuman>().objectCounter;



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

    public void SetPlayer()
    {
        if (GameObject.FindGameObjectWithTag("Player 1") != null)
        {

            player1 = GameObject.FindGameObjectWithTag("Player 1").GetComponent<ObjectSpawner>();

        }

        if (GameObject.FindGameObjectWithTag("Player 2") != null)
        {

            player2 = GameObject.FindGameObjectWithTag("Player 2").GetComponent<ObjectSpawnerHuman>();

        }
        
    }
    

}
