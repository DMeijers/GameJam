using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {

    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("The game is cloised");
    }


    public void StartGame()
    {
        SceneManager.LoadScene("UIStufff");
    }
}
