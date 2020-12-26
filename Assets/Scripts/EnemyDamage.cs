using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    [SerializeField] Collider collisionMesh;
  

    private void OnParticleCollision(GameObject other)
    {
        print("Hit Here!");
    }
}
