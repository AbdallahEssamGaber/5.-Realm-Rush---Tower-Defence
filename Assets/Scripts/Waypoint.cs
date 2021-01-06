using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    public bool isEplored = false;
    public Waypoint exploredFrom;
    public bool isPlacement = true;

    const int grideSize = 10;

    [SerializeField] Tower towerPrefab;



    public int GetGrideSize()
    {
        return grideSize;
    }


  
    public Vector2Int GetGridPos()
    {
        return new Vector2Int(

             Mathf.RoundToInt(transform.position.x / grideSize),
             Mathf.RoundToInt(transform.position.z / grideSize)

            );
    }



   
    void OnMouseDown()
    {
        if(isPlacement)
        {
            Instantiate(towerPrefab, new Vector3(transform.position.x, 10.5f, transform.position.z), Quaternion.identity);
            isPlacement = false;
        }
        else
        {
            Debug.Log("It cant be her " + gameObject);
        }
    }
 
  


}
