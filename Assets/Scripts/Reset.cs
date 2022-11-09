using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Reset : MonoBehaviour
{
    public void LoadGameOver()
    {

        SceneManager.LoadScene("Game Over");

        print("button is working.");


    }

    public void LoadGame()
    {

        SceneManager.LoadScene("Start");

        print("button is working.");


    }

}
