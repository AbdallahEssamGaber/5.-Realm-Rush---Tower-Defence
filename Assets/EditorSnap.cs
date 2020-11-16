using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[ExecuteInEditMode]
public class EditorSnap : MonoBehaviour
{
    [SerializeField] [Range(1f, 20f)] float grideSize = 10f;

    void Update()
    {
        Vector3 snap;
        snap.x = Mathf.RoundToInt(transform.position.x / grideSize) * grideSize;    
        snap.z = Mathf.RoundToInt(transform.position.z / grideSize) * grideSize;

        transform.position = new Vector3(snap.x, 0f, snap.z);
    }
}
