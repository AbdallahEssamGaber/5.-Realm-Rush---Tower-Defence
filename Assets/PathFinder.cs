using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{

    [SerializeField] Waypoint StartCube, EndCube;

    Dictionary<Vector2Int, Waypoint> grid = new Dictionary<Vector2Int, Waypoint>();
    Queue<Waypoint> queue = new Queue<Waypoint>();

    [SerializeField] bool isRunning = true;

    Vector2Int[] directions = {
        Vector2Int.up, 
        Vector2Int.right,
        Vector2Int.down,
        Vector2Int.left
    };


    void Start()
    {
        CountBlocks();
        Coloring();
        PathFinde();
        //ExploreNeighbour();
    }

    void PathFinde()
    {
        queue.Enqueue(StartCube);
        while (queue.Count > 0)
        {
            var searchCenter = queue.Dequeue();
            print(searchCenter);
            HalfIfEndFound(searchCenter);
        }

        
    }

    void HalfIfEndFound(Waypoint searchCenter)
    {
        if (searchCenter == EndCube)
        {
            print("Stopped it's The same!");
            isRunning = false;
        }
    }

    void ExploreNeighbour()
    {
        foreach (Vector2Int direction in directions)
        {
            
            Vector2Int exploredCoor = StartCube.GetGridPos() + direction;
            try
            {
                grid[exploredCoor].SetColor(Color.white);
            }
            catch
            {
        
                Debug.LogWarning("There is no cube in " + exploredCoor + " U ARE GONNA FALL OFF");
            }
        }
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
