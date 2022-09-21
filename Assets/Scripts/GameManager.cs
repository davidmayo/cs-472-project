using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    MapDisplay mapDisplay;
    // Start is called before the first frame update
    void Start()
    {
        mapDisplay = FindObjectOfType<MapDisplay>();

        // TODO
        //mapDisplay.DrawMesh()
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
