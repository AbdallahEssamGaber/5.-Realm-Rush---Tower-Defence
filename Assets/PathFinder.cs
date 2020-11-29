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
        PathFinde();
        Coloring();
    }

    void PathFinde()
    {
        queue.Enqueue(StartCube);
        while (queue.Count > 0 && isRunning)
        {
            var searchCenter = queue.Dequeue();
            print("Searching from: " +  searchCenter);
            HalfIfEndFound(searchCenter);
            ExploreNeighbor(searchCenter);
            searchCenter.isEplored = true;
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

    void ExploreNeighbor(Waypoint searchCenter) 
    {
        if (!isRunning) { return; };
        foreach (Vector2Int direction in directions)
        {
            
            Vector2Int neighborCoor = searchCenter.GetGridPos() + direction;
            try
            {
                QueueNewNeighbour(neighborCoor);
            }
            catch
            {
               
            }
        }
    }

    void QueueNewNeighbour(Vector2Int exploredCoor)
    {
        Waypoint neighbour = grid[exploredCoor];
        if (neighbour.isEplored)
        {
            return;
        }
        else
        {
            neighbour.SetColor(Color.blue);
            queue.Enqueue(neighbour);
            print("Queueing : " + neighbour);
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

      }

    
}
