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
    [SerializeField] GameObject test;

    float timer = enemyMovement.speedOfTheE;

    public static int hits = 10;


    int s;





    private void Update()
    {
        if (timer < 0)
        {
            timer = 0;
        }
        if (test.activeInHierarchy && timer > 0)
        {
            timer -= Time.deltaTime * 2;
        }
    }
    void OnParticleCollision(GameObject other)
    {
        if (hits == 0)
        {

            PrintDE.enter = true;
            DeathThing();


            return;
        }
        hits--;
        timer += enemyMovement.speedOfTheE;
        s++;
        print("hits " + hits);
        hitParticle.Play();
        test.SetActive(true);
        ppv();
        //StartCoroutine(testsd());



        GetComponent<AudioSource>().PlayOneShot(shootSFX);



    }


    void ppv()
	{
        while (timer != 0)
        {
            print(timer);
            test.SetActive(true);
            return;
        }
        print(4654);
        test.SetActive(false);
        timer = enemyMovement.speedOfTheE;
    }

 //   IEnumerator ppv()
	//{
 //       while(timer!=0)
	//	{
 //           print(timer);
 //           test.SetActive(true);
 //           yield return null;
 //       }
 //       print(4654);
 //       test.SetActive(false);
 //       timer = enemyMovement.speedOfTheE;
 //       yield return null;
	//}


    IEnumerator testsd()
	{
        print("d " +s);

        yield return new WaitForSeconds(0.4f);


        if (timer == 0)
		{
            print(s);
                    s = 0;

            print("as" + enemyMovement.speedOfTheE * s);
            yield return new WaitForSeconds(enemyMovement.speedOfTheE);
            test.SetActive(false);
        }
        else
		{
            test.SetActive(false);
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
