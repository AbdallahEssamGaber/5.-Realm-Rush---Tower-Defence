﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{
    [SerializeField] int baseHealth = 5;
    [SerializeField] int healthDecrease = 1;
    [SerializeField] Text healthText;
    [SerializeField] LoadScenes SceneLoaderObj;




    void Start()
     {
        healthText.text = baseHealth.ToString();
    }




    void OnTriggerEnter(Collider other)
    {


        if(baseHealth <= 1)
        {
            SceneLoaderObj.LoseLoad();
            PrintDE.nOfDaedEnemies = 0;

            return;
        }

        baseHealth -= healthDecrease;
        healthText.text = baseHealth.ToString();
       

    }



    

   
}
