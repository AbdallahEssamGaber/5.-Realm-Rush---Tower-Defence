using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{

    [SerializeField] Waypoint StartCube, EndCube;

    Dictionary<Vector2Int, Waypoint> grid = new Dictionary<Vector2Int, Waypoint>();


    [SerializeField] Waypoint cube; //This for the prefab cube to make new one

    Vector2Int[] directions = {
        Vector2Int.up, 
        Vector2Int.right,
        Vector2Int.down,
        Vector2Int.left
    };


    string[] dirNames = {       //Adding the names to know what side there is no cube in it
        "Up",
        "Right",
        "Down",
        "Left"
    };

    void Start()
    {
        Coloring();
        CountBlocks();
        ExploreNeighbour();
    }

    void ExploreNeighbour()
    {
        int timesInLoop = 0;        //Get the time in the foreach so it can decide what side
        int gridSize = StartCube.GetGrideSize();    //This for gettign the grid size to multiply by the postition to make grid size
        foreach (Vector2Int direction in directions)
        {
            
            Vector2Int exploredCoor = StartCube.GetGridPos() + direction;
            try
            {
                grid[exploredCoor].SetColor(Color.white);
            }
            catch
            {
               
                Waypoint newCube = Instantiate(cube, new Vector3(exploredCoor.x * gridSize, 0, exploredCoor.y * 10) , Quaternion.identity);     //Make a new cube with right coor
                newCube.transform.parent = gameObject.transform;    //Put it child to World object

                grid.Add(newCube.GetGridPos(), newCube);    //And then add it to the dictionary to color it 
                newCube.SetColor(Color.yellow);         //Coloring it

                Debug.LogWarning("There is no cube in " + dirNames[timesInLoop] + "Side, I ADDED ONE FOR U :)");
            }
            timesInLoop++;          //Increasing it cuz that's a loop
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
