using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PrintDE : MonoBehaviour
{
    [SerializeField] Text enemyDeadText;
    [SerializeField] LoadScenes loader;

    [SerializeField] EnemySpawner spawnS;

    public static bool enter = false; //to control it from enemyDamege

    public static int nOfDaedEnemies;


    float essential;
    void Start()
    {
        enemyDeadText.text = nOfDaedEnemies.ToString() + "/6";
    }

    void Update()
    {


        if(nOfDaedEnemies >= 6)
        {
            loader.WinLoad();
        }

        if (enter)
        {
            nOfDaedEnemies++;
            enemyDeadText.text = nOfDaedEnemies.ToString() + "/6";

            enter = false;   //to make it enter her just one time cuz its Update
        }
    }
    public float CheckAgain()
    {

        if (nOfDaedEnemies > 2 && nOfDaedEnemies < 4)
        {
            essential = 5.9f;

        }
        else if (PrintDE.nOfDaedEnemies > 4)
        {

            essential = 7.5f;
        }
        else
        {
            essential = 10f;
        }
        return essential;


    }




}
