using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;

    public void SpawnPlayer()
    {
        //AudioManager.Instance.play("epic");
        //AudioManager.Instance.play("level_select");
        if (GameObject.FindGameObjectWithTag("Player"))
            Instantiate(Player2);
        else
            Instantiate(Player1);
    }
}
