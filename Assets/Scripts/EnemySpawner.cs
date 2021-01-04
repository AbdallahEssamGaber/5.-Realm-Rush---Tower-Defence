using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] float secondsBetweenSpawns = 2f;
    [SerializeField] enemyMovement enemyprefab;

    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while(true)
        {
            print("spawn");
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
        
    }
}
