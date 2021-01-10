using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    [SerializeField] Collider collisionMesh;
    [SerializeField] ParticleSystem hitParticle;
    [SerializeField] ParticleSystem deathParticle;


    int hits = 6;

    void OnParticleCollision(GameObject other)
    {
        if (hits == 0)
        {
            Instantiate(deathParticle, transform.position, Quaternion.identity);

            Destroy(gameObject);
            return;
        }

        hits--;
        hitParticle.Play();


    }
    


}
