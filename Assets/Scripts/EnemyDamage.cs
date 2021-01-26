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
    [SerializeField] GameObject hitsAlways;
    [SerializeField] enemyMovement enemyS;
    [SerializeField] HandlerIn handlerin;

    float timer;

    public int hits = 10;


    int s;



    void Start()
    {
        hits = handlerin.HitsCheck();
    }

    private void Update()
    {
        if (timer < 0)
        {
            timer = 0;
        }
        if (hitsAlways.activeInHierarchy && timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }
    void OnParticleCollision(GameObject other)
    {
       
        if (hits <= 1)
        {

            PrintDE.enter = true;
            DeathThing();


            return;
        }
        hits--;
        timer += enemyS.speedOfTheE;
        s++;
        hitParticle.Play();
        hitsAlways.SetActive(true);
        //ppv();
        //StartCoroutine(testsd());
        StartCoroutine(ppv());



        GetComponent<AudioSource>().PlayOneShot(shootSFX);



    }


    //   void ppv()
    //{
    //       while (timer != 0)
    //       {
    //           test.SetActive(true);
    //           return;
    //       }
    //       test.SetActive(false);
    //       timer = enemyMovement.speedOfTheE;
    //   }

    IEnumerator ppv()
    {
        while (timer != 0)
        {
            hitsAlways.SetActive(true);
            yield return null;
        }
        hitsAlways.SetActive(false);
        yield return null;
    }


    IEnumerator testsd()
    {

        yield return new WaitForSeconds(0.4f);


        if (timer == 0)
        {
            s = 0;

            print("as" + enemyS.speedOfTheE * s);
            yield return new WaitForSeconds(enemyS.speedOfTheE);
            hitsAlways.SetActive(false);
        }
        else
        {
            hitsAlways.SetActive(false);
        }

    }


    public void DeathThing()
    {

        var vfx = Instantiate(deathParticle, transform.position, Quaternion.identity);
        Destroy(vfx.gameObject, vfx.main.duration);


        AudioSource.PlayClipAtPoint(dieSFX, Camera.main.transform.position);

        Destroy(gameObject, 0.1f);




    }



}