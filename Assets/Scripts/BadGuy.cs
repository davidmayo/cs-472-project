using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class BadGuy : MonoBehaviour
{
    Reset Lscript;
    public GameObject camera;
    private Transform Player;
    private NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    { //This code shows the bad guy that it will follow the player
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();

        Lscript = camera.GetComponent<Reset>();
    }

    // Update is called once per frame
    void Update()
    {//This is so the bad guy is always update on the players location
        nav.SetDestination(Player.position);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Lscript.LoadGameOver();
            Debug.Log("Inside condition");

        }
        Debug.Log("Outside condition");
    }
}

// This is a Mayo comment