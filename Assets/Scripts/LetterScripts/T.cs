using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T : MonoBehaviour
{
 public Vector3 spawnPos;
    public Quaternion spawnRot;
    // Start is called before the first frame update
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
