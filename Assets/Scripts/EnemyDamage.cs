using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    [SerializeField] Collider collisionMesh;
    [SerializeField] ParticleSystem hitParticle;
    [SerializeField] ParticleSystem deathParticle;
    [SerializeField] AudioClip shootSFX;
    [SerializeField] AudioClip dieSFX;


    public static int hits = 10;





   


    void OnParticleCollision(GameObject other)
    {
        if (hits == 0)
        {

            PrintDE.enter = true;
            DeathThing();


            return;
        }

        hits-=10;
        hitParticle.Play();

        


        GetComponent<AudioSource>().PlayOneShot(shootSFX);



    }

    public void DeathThing()
    {
      
        var vfx = Instantiate(deathParticle, transform.position, Quaternion.identity);
        Destroy(vfx.gameObject, vfx.main.duration);


        AudioSource.PlayClipAtPoint(dieSFX, Camera.main.transform.position);

        Destroy(gameObject, 0.1f);

       


    }
}
