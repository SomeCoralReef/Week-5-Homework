using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IBoundry : MonoBehaviour
{
    public I I;
    public TriggerBox TriggerBox;
    public TriggerBoxTwo TriggerBoxTwo;
    public TriggerBoxThree TriggerBoxThree;
    public TriggerBoxFour TriggerBoxFour;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D activator){
        if(activator.tag == "TriggerBox1"){
            Vector3 position = activator.transform.position;
            I.transform.position = position + new Vector3 (0f,0f,-1f);
            I.GetComponent<Rigidbody2D>().velocity = Vector3.zero; 
            I.GetComponent<Rigidbody2D>().angularVelocity = 0;
            I.transform.rotation = I.spawnRot;
        } else if(activator.tag == "TriggerBox2"){
            Vector3 position = activator.transform.position;
            I.transform.position = position + new Vector3 (0f,0f,-1f);
            I.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            I.GetComponent<Rigidbody2D>().angularVelocity = 0;
            I.transform.rotation = I.spawnRot;
        } else if(activator.tag == "TriggerBox3"){
            Vector3 position = activator.transform.position;
            I.transform.position = position + new Vector3 (0f,0f,-1f);
            I.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            I.GetComponent<Rigidbody2D>().angularVelocity = 0;
            I.transform.rotation = I.spawnRot;
        } else if(activator.tag == "TriggerBox4"){
            Vector3 position = activator.transform.position;
            I.transform.position = position + new Vector3 (0f,0f,-1f);
            I.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            I.GetComponent<Rigidbody2D>().angularVelocity = 0;
            I.transform.rotation = I.spawnRot;
        }
    }
}
