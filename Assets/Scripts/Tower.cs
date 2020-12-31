using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] Transform objectToPan;
    [SerializeField] Transform objectEnemy;
    [SerializeField] float range = 10f;
    [SerializeField] ParticleSystem shootParticle;
    [SerializeField] GameObject destroyParticle;


    void Update()
    {
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