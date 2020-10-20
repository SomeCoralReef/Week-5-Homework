using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JBoundry : MonoBehaviour
{
    public J J;
    public TriggerBox TriggerBox;
    // Start is called before the first frame update
  void OnTriggerEnter2D(Collider2D activator){
        if(activator.tag == "TriggerBox1"){
            Vector3 position = activator.transform.position;
            J.transform.position = position + new Vector3 (0f,0f,-1f);
            J.GetComponent<Rigidbody2D>().velocity = Vector3.zero; 
            J.GetComponent<Rigidbody2D>().angularVelocity = 0;
            J.transform.rotation = J.spawnRot;
        } else if(activator.tag == "TriggerBox2"){
            Vector3 position = activator.transform.position;
            J.transform.position = position + new Vector3 (0f,0f,-1f);
            J.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            J.GetComponent<Rigidbody2D>().angularVelocity = 0;
            J.transform.rotation = J.spawnRot;
        } else if(activator.tag == "TriggerBox3"){
            Vector3 position = activator.transform.position;
            J.transform.position = position + new Vector3 (0f,0f,-1f);
            J.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            J.GetComponent<Rigidbody2D>().angularVelocity = 0;
            J.transform.rotation = J.spawnRot;
        } else if(activator.tag == "TriggerBox4"){
            Vector3 position = activator.transform.position;
            J.transform.position = position + new Vector3 (0f,0f,-1f);
            J.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            J.GetComponent<Rigidbody2D>().angularVelocity = 0;
            J.transform.rotation = J.spawnRot;
        }
    }
}
