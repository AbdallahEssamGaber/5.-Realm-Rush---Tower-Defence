﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    public bool isEplored = false;
    public Waypoint exploredFrom;


    const int grideSize = 10;

    
    public void SetColor(Color color)
    {
        MeshRenderer meshRenderer = transform.Find("top").GetComponent<MeshRenderer>();
        meshRenderer.material.color = color;

    }


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



  


}