using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    [SerializeField] List<Block> paths;

    void Start()
    {
        foreach(Block path in paths)
        {
            print(path);
        }
    }

    void Update()
    {
       
    }
}
