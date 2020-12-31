using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{

    [SerializeField] Collider collisionMesh;
    [SerializeField] ParticleSystem destroyParticle;

    public List<ParticleCollisionEvent> collisionEvents;

    ParticleSystem part;

  

    Vector3 pos;
    void Start()
    {
        part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
    }

    void OnParticleCollision(GameObject other)
    {


       

        int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);
        
        for (int i = 0; i < numCollisionEvents; i++)
		{
            pos = collisionEvents[i].intersection;
        }

        

        destroyParticle.transform.position = pos;
       
        destroyParticle.Play();

      

    }



}
