using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABoundry : MonoBehaviour
{
    public A A;
    public TriggerBox TriggerBox;
    public TriggerBoxTwo TriggerBoxTwo;
    public TriggerBoxThree TriggerBoxThree;
    public TriggerBoxFour TriggerBoxFour;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D activator){
        if(activator.tag == "TriggerBox1"){
            Vector3 position = activator.transform.position;
            A.transform.position = position + new Vector3 (0f,0f,-1f);
            A.GetComponent<Rigidbody2D>().velocity = Vector3.zero; 
            A.GetComponent<Rigidbody2D>().angularVelocity = 0;
            A.transform.rotation = A.spawnRot;
        } else if(activator.tag == "TriggerBox2"){
            Vector3 position = activator.transform.position;
            A.transform.position = position + new Vector3 (0f,0f,-1f);
            A.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            A.GetComponent<Rigidbody2D>().angularVelocity = 0;
            A.transform.rotation = A.spawnRot;
        } else if(activator.tag == "TriggerBox3"){
            Vector3 position = activator.transform.position;
            A.transform.position = position + new Vector3 (0f,0f,-1f);
            A.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            A.GetComponent<Rigidbody2D>().angularVelocity = 0;
            A.transform.rotation = A.spawnRot;
        } else if(activator.tag == "TriggerBox4"){
            Vector3 position = activator.transform.position;
            A.transform.position = position + new Vector3 (0f,0f,-1f);
            A.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            A.GetComponent<Rigidbody2D>().angularVelocity = 0;
            A.transform.rotation = A.spawnRot;
        }
    }
}
