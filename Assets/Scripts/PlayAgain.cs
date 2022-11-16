using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayAgain : MonoBehaviour
{
    public void LoadGame()
    {

        SceneManager.LoadScene("Won");

        print("button is working.");


    }

    public void Restart()
    {

        SceneManager.LoadScene("Start");

        print("button is working.");


    }

}
