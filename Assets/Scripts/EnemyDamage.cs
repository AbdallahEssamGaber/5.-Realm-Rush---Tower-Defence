using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    [SerializeField] Collider collisionMesh;

    int hits = 10;

    private void OnParticleCollision(GameObject other)
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
