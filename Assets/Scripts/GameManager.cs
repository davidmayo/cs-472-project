using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void Start()
    {
        MapGenerator mapGenerator = FindObjectOfType<MapGenerator>();
        mapGenerator.GenerateMap();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
