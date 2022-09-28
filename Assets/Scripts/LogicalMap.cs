using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalMap : MonoBehaviour
{
    MapGenerator mapGenerator;
    // Start is called before the first frame update
    void Start()
    {
        mapGenerator = FindObjectOfType<MapGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetTerrainType(Vector2 gridCoordinate)
    {


        return "";
    }

    public Vector2Int GetGridCoordinate(Transform transform)
    {
        return GetGridCoordinate(transform.position);
    }

    public Vector2Int GetGridCoordinate(GameObject obj)
    {
        return GetGridCoordinate(obj.transform.position);
    }

    public Vector2Int GetGridCoordinate(Vector3 worldPosition)
    {
        int mapWidth = mapGenerator.mapWidth;
        int mapHeight = mapGenerator.mapHeight;

        float worldX = worldPosition.x;
        float worldY = worldPosition.z;

        int xCoord = (int)worldX + mapWidth / 2;
        int yCoord = (int)worldY + mapHeight / 2;

        return new Vector2Int(xCoord, yCoord);
    }
}
