using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    [SerializeField] List<Waypoint> path;

    void Start()
    {
        
        StartCoroutine(FollowPath());

    }
    
    IEnumerator FollowPath()
    {
        print("Strating patrol....");
        foreach (Waypoint waypoint in path)
        {
            Vector3 palying;
            palying.x = waypoint.transform.position.x;
            palying.z = waypoint.transform.position.z;
            transform.position = new Vector3(palying.x, gameObject.transform.position.y, palying.z);
            print("Visiting block: " + waypoint.name);

            yield return new WaitForSeconds(1);
        }
        print("Ending patrol");
    }
    
}
