using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] PrintDE printde;

    [Range(0, 12)][SerializeField] public float secondsBetweenSpawns = 10;
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


            yield return new WaitForSeconds(secondsBetweenSpawns);

            Instantiate(enemyprefab, transform.position, Quaternion.identity).transform.parent = gameObject.transform;


            GetComponent<AudioSource>().PlayOneShot(SpawnedSFX);




        }

    }

    private void Update()
    {
        secondsBetweenSpawns = printde.CheckAgain();

    }


}
