using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PrintDE : MonoBehaviour
{
    [SerializeField] Text textOfDiedEnemeis;
    [SerializeField] EnemyDamage enemydamage;


    public int nOfDiedEnemeis = 1;

    void Start()
    {
        //print("HDRDisplaySupportFlags");
      textOfDiedEnemeis.text = nOfDiedEnemeis.ToString() + "/5";
    }





    void Update()
    {
        print(nOfDiedEnemeis);
        textOfDiedEnemeis.text = nOfDiedEnemeis.ToString() + "/5";
    }

   
}
