using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int baseHealth = 5;
    [SerializeField] int healthDecrease = 1;
    [SerializeField] Text healthText;




     void Start()
     {
        healthText.text = baseHealth.ToString();
     }

    void OnTriggerEnter(Collider other)
    {
        baseHealth -= healthDecrease;
        healthText.text = baseHealth.ToString();
    }
}
