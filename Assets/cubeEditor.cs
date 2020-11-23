﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
[SelectionBase]
[RequireComponent(typeof(Waypoint))]
public class CubeEditor : MonoBehaviour
{

    Waypoint waypoint;


    void Awake()
    {
        waypoint = GetComponent<Waypoint>();
    }


    void Update()
    {

        SnapToGrid();
        UpdateLabel();

    }

    void SnapToGrid()
    {

        int grideSize = waypoint.GetGrideSize();
        transform.position = new Vector3(waypoint.GetGridPos().x, 0f, waypoint.GetGridPos().y);
    }

    void UpdateLabel()
    {
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        int grideSize = waypoint.GetGrideSize();
        string labelText = waypoint.GetGridPos().x / grideSize + "," + waypoint.GetGridPos().y / grideSize;
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}
