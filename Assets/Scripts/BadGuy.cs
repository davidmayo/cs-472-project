using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class BadGuy : MonoBehaviour
{
    Reset Lscript;
    //private GameObject camera;
    public Transform playerTransform;
    public NavMeshAgent navMeshAgent;

    public TerrainCollider terrainCollider;
    public LayerMask terrainMask;

    // Start is called before the first frame update
    void Start()
    {
        //This code shows the bad guy that it will follow the player
        //playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        //navMeshAgent = GetComponent<NavMeshAgent>();

        //Lscript = camera.GetComponent<Reset>();
        Lscript = FindObjectOfType<Reset>();
    }

    // Update is called once per frame
    void Update()
    {
        //This is so the bad guy is always update on the players location
        if (navMeshAgent.isOnNavMesh)
        {
            //Debug.Log($"Bad Guy IS on NavMesh pos={this.transform.position}");

            navMeshAgent.destination = playerTransform.position;
            Debug.Log($"Bad Guy IS on NavMesh pos={this.transform.position}\tSetting target to {playerTransform.position}\tdest={navMeshAgent.destination}");
        }
        else
        {
            string message = $"NOT ON NAV MESH";

            // Get onto the nav mesh, somehow.
            NavMeshTriangulation navMeshTriangulation = NavMesh.CalculateTriangulation();
            message += $"\tnavMeshTriangulation = {navMeshTriangulation} Length={navMeshTriangulation.vertices.Length}";
            int index = Random.Range(0, navMeshTriangulation.vertices.Length);
            NavMeshHit hit;

            if(NavMesh.SamplePosition(navMeshTriangulation.vertices[index], out hit, 20000f, NavMesh.AllAreas))
            {
                message += $"\tTELEPORTING to {hit.position}";
                navMeshAgent.Warp(hit.position);
            }
            else
            {
                message += $"\tSamplePosition() was false. hit={hit}";
            }
            Debug.Log(message);

            //// Manually force the y value to collide with the terrain
            //RaycastHit raycastHit;

            //string message = $"WARNING: Bad Guy NOT on NavMesh pos={this.transform.position}";

            //if (Physics.Raycast(transform.position, Vector3.down, out raycastHit, maxDistance: 100f, layerMask: terrainMask) ||
            //    Physics.Raycast(transform.position, Vector3.up,   out raycastHit, maxDistance: 100f, layerMask: terrainMask))
            //{

            //    Debug.Log($"{message}\nMoving to {raycastHit.point}");
            //    this.transform.position = raycastHit.point;
            //}
            //else
            //{
            //    Debug.Log($"{message}\nERROR: Cannot find position on terrain");
            //}
        }
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