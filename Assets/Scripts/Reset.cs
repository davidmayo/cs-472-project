using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Reset : MonoBehaviour
{
    public void ResetTheGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        print("button is working.");


    }

    public void ResetCurrentScene()
    {

        int currentScene = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentScene);

    }
}
