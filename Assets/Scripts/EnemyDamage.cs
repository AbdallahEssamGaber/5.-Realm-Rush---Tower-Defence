using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    [SerializeField] Collider collisionMesh;
    [SerializeField] GameObject destroyParticle;

    int hits = 10;

    private void OnParticleCollision(GameObject other)
    {
        destroyParticle.SetActive(true);

     
        hits--;
        print("Hit Here!, the hits num: " + hits);
        StartCoroutine(LateCall());


    }

    IEnumerator LateCall()
    {
        
        yield return new WaitForSeconds(0.2f);
        
        destroyParticle.SetActive(false);
        print("D");
        if (hits <= 0)
        {
            Destroy(gameObject);
            
        }
    }

   
}
