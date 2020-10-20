using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rboundry : MonoBehaviour
{

    public R R;
    public TriggerBox TriggerBox;
    // Start is called before the first frame update
 void OnTriggerEnter2D(Collider2D activator){
        if(activator.tag == "TriggerBox1"){
            Vector3 position = activator.transform.position;
            R.transform.position = position + new Vector3 (0f,0f,-1f);
            R.GetComponent<Rigidbody2D>().velocity = Vector3.zero; 
            R.GetComponent<Rigidbody2D>().angularVelocity = 0;
            R.transform.rotation = R.spawnRot;
        } else if(activator.tag == "TriggerBox2"){
            Vector3 position = activator.transform.position;
            R.transform.position = position + new Vector3 (0f,0f,-1f);
            R.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            R.GetComponent<Rigidbody2D>().angularVelocity = 0;
            R.transform.rotation = R.spawnRot;
        } else if(activator.tag == "TriggerBox3"){
            Vector3 position = activator.transform.position;
            R.transform.position = position + new Vector3 (0f,0f,-1f);
            R.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            R.GetComponent<Rigidbody2D>().angularVelocity = 0;
            R.transform.rotation = R.spawnRot;
        } else if(activator.tag == "TriggerBox4"){
            Vector3 position = activator.transform.position;
            R.transform.position = position + new Vector3 (0f,0f,-1f);
            R.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            R.GetComponent<Rigidbody2D>().angularVelocity = 0;
            R.transform.rotation = R.spawnRot;
        }
    }
}
