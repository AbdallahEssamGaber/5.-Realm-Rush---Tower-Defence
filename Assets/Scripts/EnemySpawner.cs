using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [Range(0, 10)][SerializeField] float secondsBetweenSpawns = 2f;
    [SerializeField] enemyMovement enemyprefab;
    [SerializeField] AudioClip SpawnedSFX;


    void Start()
    {
        StartCoroutine(spawner());
    }

    IEnumerator spawner()
    {
        while (true)
        {
            Instantiate(enemyprefab, transform.position, Quaternion.identity).transform.parent = gameObject.transform;

            EnemyDamage.hits = 10;

            GetComponent<AudioSource>().PlayOneShot(SpawnedSFX);

            yield return new WaitForSeconds(secondsBetweenSpawns);

            

        }

    }



    
}
