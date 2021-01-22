using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    PathFinder pathFinder;

    [SerializeField] ParticleSystem winParticle;
    [SerializeField] AudioClip baseSFX;
    [SerializeField] GameObject dieSFX;

    void Start()
    {


        pathFinder = FindObjectOfType<PathFinder>();
        var path = pathFinder.GetPath();
        
        StartCoroutine(FollowPath(path));
        
    }

    IEnumerator FollowPath(List<Waypoint> path)
    {
        foreach (Waypoint waypoint in path)
        {
            Vector3 palying;
            palying.x = waypoint.transform.position.x;
            palying.z = waypoint.transform.position.z;
            transform.position = new Vector3(palying.x, gameObject.transform.position.y, palying.z);
            
            yield return new WaitForSeconds(0.5f);

           
            
        }
        print("Win");
        var vfx = Instantiate(winParticle, transform.position, Quaternion.identity);
        Destroy(vfx.gameObject, vfx.main.duration);

        AudioSource.PlayClipAtPoint(baseSFX, Camera.main.transform.position);

        Destroy(gameObject);


    }

 
}
