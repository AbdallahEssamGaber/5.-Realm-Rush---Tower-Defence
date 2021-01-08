using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [Range(1, 10)][SerializeField] float secondsBetweenSpawns = 2f;
    [SerializeField] enemyMovement enemyprefab;

    void Start()
    {
        StartCoroutine(spawner());
    }

    IEnumerator spawner()
    {
        while (true)
        {

            yield return new WaitForSeconds(secondsBetweenSpawns);

            Instantiate(enemyprefab, transform.position, Quaternion.identity);

        }

    }
}
