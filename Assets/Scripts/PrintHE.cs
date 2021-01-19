using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintHE : MonoBehaviour
{
    [SerializeField] public Text enemyHealth;



    void Update()
    {
        enemyHealth.text = EnemyDamage.hits.ToString();

    }
}
