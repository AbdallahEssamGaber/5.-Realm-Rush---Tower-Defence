using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] Transform objectToPan;
    [SerializeField] Transform objectEnemy;

    void Update()
    {
        objectToPan.LookAt(objectEnemy);
    }
}