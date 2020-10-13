using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X : MonoBehaviour
{

 public Vector3 spawnPos;
public Quaternion spawnRot;

    void Start()
    {
        spawnPos = transform.position;
        spawnRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
