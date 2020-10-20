using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBoundry : MonoBehaviour
{

    public O O;
    public TriggerBox TriggerBox;
    // Start is called before the first frame update
 void OnTriggerEnter2D(Collider2D activator){
        if(activator.tag == "TriggerBox1"){
            Vector3 position = activator.transform.position;
            O.transform.position = position + new Vector3 (0f,0f,-1f);
            O.GetComponent<Rigidbody2D>().velocity = Vector3.zero; 
            O.GetComponent<Rigidbody2D>().angularVelocity = 0;
            O.transform.rotation = O.spawnRot;
        } else if(activator.tag == "TriggerBox2"){
            Vector3 position = activator.transform.position;
            O.transform.position = position + new Vector3 (0f,0f,-1f);
            O.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            O.GetComponent<Rigidbody2D>().angularVelocity = 0;
            O.transform.rotation = O.spawnRot;
        } else if(activator.tag == "TriggerBox3"){
            Vector3 position = activator.transform.position;
            O.transform.position = position + new Vector3 (0f,0f,-1f);
            O.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            O.GetComponent<Rigidbody2D>().angularVelocity = 0;
            O.transform.rotation = O.spawnRot;
        } else if(activator.tag == "TriggerBox4"){
            Vector3 position = activator.transform.position;
            O.transform.position = position + new Vector3 (0f,0f,-1f);
            O.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            O.GetComponent<Rigidbody2D>().angularVelocity = 0;
            O.transform.rotation = O.spawnRot;
        }
    }
}
