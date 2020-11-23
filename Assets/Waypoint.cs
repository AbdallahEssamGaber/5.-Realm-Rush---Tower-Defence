using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    const int grideSize = 10;

    
    public void SetColor(Waypoint start, Color startColor, Waypoint end, Color endColor)
    {
        MeshRenderer startMeshRander = start.transform.Find("top").GetComponent<MeshRenderer>();
        startMeshRander.material.color = startColor;
        MeshRenderer endMeshRander = end.transform.Find("top").GetComponent<MeshRenderer>();
        endMeshRander.material.color = endColor;
    }


    public int GetGrideSize()
    {
        return grideSize;
    }


  
    public Vector2Int GetGridPos()
    {
        return new Vector2Int(

             Mathf.RoundToInt(transform.position.x / grideSize) * grideSize,
             Mathf.RoundToInt(transform.position.z / grideSize) * grideSize

            );
    }


}
