using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    [SerializeField] Transform objectToPan;
    [SerializeField] float range = 10f;
    [SerializeField] ParticleSystem shootParticle;


    Transform objectEnemy;

    void Update()
    {
        SetTargetEnemy();
        if(objectEnemy)
        {
            objectToPan.LookAt(objectEnemy);
            FireAtEnemy();
        }
        else
        {
            shoot(false);
        }
        
    }

    void SetTargetEnemy()
    {
        var eniemiesWorld = FindObjectsOfType<EnemyDamage>();
        if(eniemiesWorld.Length == 0) { return; }

        Transform closestEnemy = eniemiesWorld[0].transform;

        foreach(EnemyDamage testEnemy in eniemiesWorld)
        {
            closestEnemy = GetColsest(closestEnemy, testEnemy.transform);
        }

        objectEnemy = closestEnemy;
    }

    Transform GetColsest(Transform closestEnemy, Transform testEnemy)
    {
        float distanceClosestEnemy = Vector3.Distance(closestEnemy.transform.position, gameObject.transform.position);
        float distanceTestEnemy = Vector3.Distance(testEnemy.transform.position, gameObject.transform.position);

        if(distanceClosestEnemy > distanceTestEnemy)
        {
            return testEnemy;
        }
    
        return closestEnemy;
       
    }

    void FireAtEnemy()
    {
        float distance = Vector3.Distance(objectEnemy.transform.position, gameObject.transform.position);
        if(distance <= range)
        {
            shoot(true);
        }
        else
        {
            shoot(false);
        }
    }

    void shoot(bool isActive)
    {
        var emissionModule = shootParticle.emission;
        emissionModule.enabled = isActive;
    }
}