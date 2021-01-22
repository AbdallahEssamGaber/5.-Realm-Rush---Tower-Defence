using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PrintDE : MonoBehaviour
{
    [SerializeField] Text enemyDeadText;
    [SerializeField] LoadScenes loader;

    public static bool enter = false; //to control it from enemyDamege

    int nOfDaedEnemies;




    void Start()
    {
        enemyDeadText.text = nOfDaedEnemies.ToString() + "/5";
    }

    void Update()
    {

        if(nOfDaedEnemies >= 5)
        {
            loader.WinLoad();
        }

        if (enter)
        {
            nOfDaedEnemies++;
            enemyDeadText.text = nOfDaedEnemies.ToString() + "/5";

            enter = false;   //to make it enter her just one time cuz its Update
        }
    }


}
