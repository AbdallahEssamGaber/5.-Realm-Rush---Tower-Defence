using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDamegeSFX : MonoBehaviour
{
    [SerializeField] AudioClip dieSFX;
    



    public void PlaySFX()
    {

        GetComponent<AudioSource>().PlayOneShot(dieSFX);
     

    }


}
