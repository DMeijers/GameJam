using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;

    public GameObject timer;
    public void SpawnPlayer()
    {

        //AudioManager.Instance.play("epic");
        //AudioManager.Instance.play("level_select");
        if (GameObject.FindGameObjectWithTag("Player 1"))
            Instantiate(Player2);
        


        else
            Instantiate(Player1);

        timer.GetComponent<Timer>().SetPlayer();
        // timer.GetComponent<Timer>().StartTimer();
    }
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player 2"))
        {
            timer.GetComponent<Timer>().SetPlayer();
            timer.GetComponent<Timer>().StartTimer();
            Debug.Log("Human Exists");
        }

        else Debug.Log("Human Doesn't exist");
    }

}
