using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XBoundry : MonoBehaviour
{
 
    public X X;
    public TriggerBox TriggerBox;
    // Start is called before the first frame update
   void OnTriggerEnter2D(Collider2D activator){

        if(activator.tag == "TriggerBox1"){
            Vector3 position = activator.transform.position;
            X.transform.position = position + new Vector3 (0f,0f,-1f);
            X.GetComponent<Rigidbody2D>().velocity = Vector3.zero; 
            X.GetComponent<Rigidbody2D>().angularVelocity = 0;
            X.transform.rotation = X.spawnRot;
        } else if(activator.tag == "TriggerBox2"){
            Vector3 position = activator.transform.position;
            X.transform.position = position + new Vector3 (0f,0f,-1f);
            X.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            X.GetComponent<Rigidbody2D>().angularVelocity = 0;
            X.transform.rotation = X.spawnRot;
        } else if(activator.tag == "TriggerBox3"){
            Vector3 position = activator.transform.position;
            X.transform.position = position + new Vector3 (0f,0f,-1f);
            X.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            X.GetComponent<Rigidbody2D>().angularVelocity = 0;
            X.transform.rotation = X.spawnRot;
        } else if(activator.tag == "TriggerBox4"){
            Vector3 position = activator.transform.position;
            X.transform.position = position + new Vector3 (0f,0f,-1f);
            X.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            X.GetComponent<Rigidbody2D>().angularVelocity = 0;
            X.transform.rotation = X.spawnRot;
        }
    }
}
