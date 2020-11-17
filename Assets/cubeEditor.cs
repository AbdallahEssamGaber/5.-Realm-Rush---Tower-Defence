using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SelectionBase]
[ExecuteInEditMode]
public class cubeEditor : MonoBehaviour
{
    [SerializeField] [Range(1f, 20f)] float grideSize = 10f;

    TextMesh textMesh;

    void Update()
    {
        Vector3 snap;
        snap.x = Mathf.RoundToInt(transform.position.x / grideSize) * grideSize;    
        snap.z = Mathf.RoundToInt(transform.position.z / grideSize) * grideSize;

        transform.position = new Vector3(snap.x, 0f, snap.z);


        
        textMesh = GetComponentInChildren<TextMesh>();
        textMesh.text = snap.x / grideSize + "," + snap.z / grideSize;
    }
}
