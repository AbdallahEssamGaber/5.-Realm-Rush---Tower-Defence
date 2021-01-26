using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerIn : MonoBehaviour
{
    [SerializeField] EnemyDamage enemyD;
    [SerializeField] enemyMovement enemyS;


    int hits;
    float speedVar;



  

    public float Speed()
    {
        if (PrintDE.nOfDaedEnemies > 2 && PrintDE.nOfDaedEnemies < 4)
        {

            speedVar = 0.6f;
        }
        else if (PrintDE.nOfDaedEnemies > 4)
        {

            speedVar = 0.5f;
        }
        else
        {
            speedVar = 0.8f;
        }
        return speedVar;
    }

    public int HitsCheck()
    {

        if (PrintDE.nOfDaedEnemies > 2 && PrintDE.nOfDaedEnemies < 4)
        {
            hits = 25;

        }
        else if (PrintDE.nOfDaedEnemies > 4)
        {

            hits = 28;
        }
        else
        {
            hits = 25;
        }
        return hits;

    }




}
