using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class BadGuy : MonoBehaviour
{
    Reset Lscript;
    private Transform Player;
    private NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    { //This code shows the bad guy that it will follow the player
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {//This is so the bad guy is always update on the players location
        nav.SetDestination(Player.position);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Lscript.ResetTheGame();

        }
    }
}

// This is a Mayo comment