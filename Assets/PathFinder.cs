using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{

    [SerializeField] Waypoint StartCube, EndCube;

    Dictionary<Vector2Int, Waypoint> grid = new Dictionary<Vector2Int, Waypoint>();
    

    void Start()
    {
        Coloring();
        CountBlocks();
    }

    void Coloring()
    {
        StartCube.SetColor(Color.green);    //StartCube an object have an script have this func
        EndCube.SetColor(Color.red);        //EndCube an object have an script have this func
    }

    void CountBlocks()
     {

        var waypoints = FindObjectsOfType<Waypoint>();
        foreach(Waypoint waypoint in waypoints)
        {
            var gridPos = waypoint.GetGridPos();
            if (grid.ContainsKey(gridPos))
            {
                Debug.LogWarning("The " + gridPos + " Is Repeated!!");
            }
            else
            {
                grid.Add(gridPos, waypoint);
            }
        }

        print(grid.Count);
      }

    
}
