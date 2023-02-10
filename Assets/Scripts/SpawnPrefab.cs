using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;

    public GameObject timer;
    public GameObject cameratohide;
    public GameObject soundTrackToPlay;
    public GameObject soundTrackToStop;
    public GameObject UItoDisable;
    

    public void SpawnPlayer()
    {

        //AudioManager.Instance.play("epic");
        //AudioManager.Instance.play("level_select");
        if (GameObject.FindGameObjectWithTag("Player 1"))
            Instantiate(Player2);
        


        else
            Instantiate(Player1);
        //AudioManager.Instance.play("start_2");
        timer.GetComponent<Timer>().SetPlayer();
        cameratohide.GetComponent<DisableCamera>().DisableTheCamera();
        soundTrackToPlay.GetComponent<SoundTrack>().PlaySoundTrack();
        soundTrackToStop.GetComponent<DisableTrack>().StopSoundTrack();
        

        // timer.GetComponent<Timer>().StartTimer();
    }
    void Update()
    {
        
        
        
        if (GameObject.FindGameObjectWithTag("Player 2"))
        {
            timer.GetComponent<Timer>().SetPlayer();
            timer.GetComponent<Timer>().StartTimer();
            //Debug.Log("Human Exists");
            UItoDisable.GetComponent<WaitForPlayer>().UItoDisable();

        }

        else
        {
            UItoDisable.GetComponent<WaitForPlayer>().UItoEnable();
        }//Debug.Log("Human Doesn't exist");
    }

}
