using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    PathFinder pathFinder;
    void Start()
    {


        pathFinder = FindObjectOfType<PathFinder>();
        var path = pathFinder.GetPath();
        
        StartCoroutine(FollowPath(path));
        
    }

    IEnumerator FollowPath(List<Waypoint> path)
    {
        foreach (Waypoint waypoint in path)
        {
            Vector3 palying;
            palying.x = waypoint.transform.position.x;
            palying.z = waypoint.transform.position.z;
            transform.position = new Vector3(palying.x, gameObject.transform.position.y, palying.z);
            
            yield return new WaitForSeconds(1);

            ColoringBypassing(waypoint);
            
        }
        
    }

    void ColoringBypassing(Waypoint waypoint)
    {
        if(waypoint != pathFinder.StartCube && waypoint != pathFinder.EndCube)  //Coloring passing waypoints unless start&end one
        {
            waypoint.SetColor(Color.blue);
        }
    }
}
