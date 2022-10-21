using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Reset : MonoBehaviour
{
    public void ResetTheGame()
    {

        SceneManager.LoadScene(0);

        print("button is working.");


    }

}
