using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManagement : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D activator){
        if(activator.tag == "A"){
            Debug.Log("hi");
        }

    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
