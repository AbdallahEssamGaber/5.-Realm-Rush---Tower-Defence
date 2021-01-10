using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFactory : MonoBehaviour
{

    [SerializeField] int maxTowers = 7;
    [SerializeField] Tower towerPrefab;

    [SerializeField] Transform towerParent;


    Queue<Tower> towerQueue = new Queue<Tower>();

    public void CreatTower(Waypoint waypointCube)
    {
        print(towerQueue.Count);
        if (maxTowers > 0)
        {
            InstantiateNewTower(waypointCube);
        }
        if (maxTowers == 0)
        {
            MoveExistingTower(waypointCube);
        }

    }




    void InstantiateNewTower(Waypoint waypointCube)
    {
        var newTower = Instantiate(towerPrefab, new Vector3(waypointCube.transform.position.x, 10, waypointCube.transform.position.z), Quaternion.identity);

        newTower.transform.parent = towerParent;

        waypointCube.isPlaceable = false;



        newTower.towerBase = waypointCube;
        waypointCube.isPlaceable = false;

        towerQueue.Enqueue(newTower);

        maxTowers--;
    }



    void MoveExistingTower(Waypoint waypointCube)
    {
        var oldTower = towerQueue.Dequeue();

        oldTower.towerBase.isPlaceable = true; // free-up the block
        waypointCube.isPlaceable = false;

        oldTower.towerBase = waypointCube;

        oldTower.transform.position = new Vector3(waypointCube.transform.position.x, 10, waypointCube.transform.position.z);


        towerQueue.Enqueue(oldTower);
    }
}
