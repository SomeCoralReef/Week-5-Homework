using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G : MonoBehaviour
{
 public Vector3 spawnPos;
 public Vector3 Gpos;
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
        Gpos = transform.position;
    }
}
