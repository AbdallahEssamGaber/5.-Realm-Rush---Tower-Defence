using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerFactory : MonoBehaviour
{

    [SerializeField] int maxTowers = 9;
    [SerializeField] Tower towerPrefab;

    [SerializeField] Transform towerParent;
    [SerializeField] Text towersNumber;

    Queue<Tower> towerQueue = new Queue<Tower>();



    private void Start()
    {
        towersNumber.text = "T n: " + towerQueue.Count.ToString();
    }


    public void CreatTower(Waypoint waypointCube)
    {
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

        towersNumber.text = "T n: " + towerQueue.Count.ToString();
    }



    void MoveExistingTower(Waypoint waypointCube)
    {

        towersNumber.text = "T n: " + towerQueue.Count.ToString() + " No More:(";

        var oldTower = towerQueue.Dequeue();

        oldTower.towerBase.isPlaceable = true; // free-up the block
        waypointCube.isPlaceable = false;

        oldTower.towerBase = waypointCube;

        Destroy(towersNumber, 3f);

        oldTower.transform.position = new Vector3(waypointCube.transform.position.x, 10, waypointCube.transform.position.z);


        towerQueue.Enqueue(oldTower);
    }


  
}
