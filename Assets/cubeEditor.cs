using System.Collections;
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
        transform.position = new Vector3(
            waypoint.GetGridPos().x * grideSize,
            0f,
            waypoint.GetGridPos().y * grideSize
        );
    }

    void UpdateLabel()
    {
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        int grideSize = waypoint.GetGrideSize();
        string labelText = waypoint.GetGridPos().x + "," + waypoint.GetGridPos().y;
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}
