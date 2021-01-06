using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    public bool isEplored = false;
    public Waypoint exploredFrom;
    public bool isReplacment = true;

    const int grideSize = 10;

    
 

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
        if(isReplacment)
        {
            Debug.Log("It can be her " + gameObject);
        }
        else
        {
            Debug.Log("It cant be her " + gameObject);
        }
    }
 
  


}
