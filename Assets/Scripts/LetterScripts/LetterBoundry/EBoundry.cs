using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBoundry : MonoBehaviour
{
    public E E;
    public TriggerBox TriggerBox;
    // Start is called before the first frame update
     void OnTriggerEnter2D(Collider2D activator){
        if(activator.tag == "TriggerBox1"){
            Vector3 position = activator.transform.position;
            E.transform.position = position + new Vector3 (0f,0f,-1f);
            E.GetComponent<Rigidbody2D>().velocity = Vector3.zero; 
            E.GetComponent<Rigidbody2D>().angularVelocity = 0;
            E.transform.rotation = E.spawnRot;
        } else if(activator.tag == "TriggerBox2"){
            Vector3 position = activator.transform.position;
            E.transform.position = position + new Vector3 (0f,0f,-1f);
            E.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            E.GetComponent<Rigidbody2D>().angularVelocity = 0;
            E.transform.rotation = E.spawnRot;
        } else if(activator.tag == "TriggerBox3"){
            Vector3 position = activator.transform.position;
            E.transform.position = position + new Vector3 (0f,0f,-1f);
            E.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            E.GetComponent<Rigidbody2D>().angularVelocity = 0;
            E.transform.rotation = E.spawnRot;
        } else if(activator.tag == "TriggerBox4"){
            Vector3 position = activator.transform.position;
            E.transform.position = position + new Vector3 (0f,0f,-1f);
            E.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            E.GetComponent<Rigidbody2D>().angularVelocity = 0;
            E.transform.rotation = E.spawnRot;
        }
    }
}
