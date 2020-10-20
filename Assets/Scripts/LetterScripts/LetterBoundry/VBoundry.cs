﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VBoundry : MonoBehaviour
{

    public V V;
    public TriggerBox TriggerBox;
    // Start is called before the first frame update
void OnTriggerEnter2D(Collider2D activator){

        if(activator.tag == "TriggerBox1"){

            Vector3 position = activator.transform.position;
            V.transform.position = position + new Vector3 (0f,0f,-1f);
            V.GetComponent<Rigidbody2D>().velocity = Vector3.zero; 
            V.GetComponent<Rigidbody2D>().angularVelocity = 0;
            V.transform.rotation = V.spawnRot;
        } else if(activator.tag == "TriggerBox2"){
            Vector3 position = activator.transform.position;
            V.transform.position = position + new Vector3 (0f,0f,-1f);
            V.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            V.GetComponent<Rigidbody2D>().angularVelocity = 0;
            V.transform.rotation = V.spawnRot;
        } else if(activator.tag == "TriggerBox3"){
            Vector3 position = activator.transform.position;
            V.transform.position = position + new Vector3 (0f,0f,-1f);
            V.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            V.GetComponent<Rigidbody2D>().angularVelocity = 0;
            V.transform.rotation = V.spawnRot;
        } else if(activator.tag == "TriggerBox4"){
            Vector3 position = activator.transform.position;
            V.transform.position = position + new Vector3 (0f,0f,-1f);
            V.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            V.GetComponent<Rigidbody2D>().angularVelocity = 0;
            V.transform.rotation = V.spawnRot;
        }
    }
}