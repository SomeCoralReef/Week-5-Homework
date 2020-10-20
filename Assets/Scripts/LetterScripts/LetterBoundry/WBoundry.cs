using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WBoundry : MonoBehaviour
{
 
    public W W;
    public TriggerBox TriggerBox;
    // Start is called before the first frame update
   void OnTriggerEnter2D(Collider2D activator){
        if(activator.tag == "TriggerBox1"){
            Vector3 position = activator.transform.position;
            W.transform.position = position + new Vector3 (0f,0f,-1f);
            W.GetComponent<Rigidbody2D>().velocity = Vector3.zero; 
            W.GetComponent<Rigidbody2D>().angularVelocity = 0;
            W.transform.rotation = W.spawnRot;
        } else if(activator.tag == "TriggerBox2"){
            Vector3 position = activator.transform.position;
            W.transform.position = position + new Vector3 (0f,0f,-1f);
            W.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            W.GetComponent<Rigidbody2D>().angularVelocity = 0;
            W.transform.rotation = W.spawnRot;
        } else if(activator.tag == "TriggerBox3"){
            Vector3 position = activator.transform.position;
            W.transform.position = position + new Vector3 (0f,0f,-1f);
            W.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            W.GetComponent<Rigidbody2D>().angularVelocity = 0;
            W.transform.rotation = W.spawnRot;
        } else if(activator.tag == "TriggerBox4"){
            Vector3 position = activator.transform.position;
            W.transform.position = position + new Vector3 (0f,0f,-1f);
            W.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            W.GetComponent<Rigidbody2D>().angularVelocity = 0;
            W.transform.rotation = W.spawnRot;
        }
    }
}
