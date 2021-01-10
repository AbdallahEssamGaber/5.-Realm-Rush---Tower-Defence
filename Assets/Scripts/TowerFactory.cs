using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFactory : MonoBehaviour
{

    [SerializeField] int maxTowers = 7;
    [SerializeField] Tower towerPrefab;

    public void CreatTower(Waypoint waypointCube)
    {
        if (maxTowers > 0)
        {
            Instantiate(towerPrefab, new Vector3(waypointCube.transform.position.x, 10, waypointCube.transform.position.z), Quaternion.identity);
            waypointCube.isPlacement = false;

            maxTowers--;
        }
        
    }
}
