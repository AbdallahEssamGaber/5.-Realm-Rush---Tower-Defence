using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintHE : MonoBehaviour
{
    [SerializeField] public Text enemyHealth;
    [SerializeField] EnemyDamage enemyDamage;


    void Update()
    {
        enemyHealth.text = enemyDamage.hits.ToString();

    }
}
