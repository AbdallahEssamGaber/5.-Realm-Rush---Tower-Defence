using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamege : MonoBehaviour
{







    int hits = 10;


    void OnParticleCollision(GameObject other)
    {


        if (hits <= 0)
        {
            Destroy(gameObject);
            return;
        }

 
        hits--;
        print("Hit Here!, the hits num: " + hits);

    }



}
