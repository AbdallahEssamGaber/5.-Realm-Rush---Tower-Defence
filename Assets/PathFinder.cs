using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{

    [SerializeField] List<Waypoint> cube;

    Dictionary<Vector2Int, Waypoint> grid = new Dictionary<Vector2Int, Waypoint>();
    

    void Start()
    {
        
        CountBlocks();
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
                waypoint.SetColor(cube[0], Color.green, cube[1], Color.red);
                grid.Add(gridPos, waypoint);
            }
        }

        print(grid.Count);
      }

    
}
