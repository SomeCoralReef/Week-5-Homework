using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mvoe2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
             if(Input.GetKey(KeyCode.Space)){
            GetComponent<Transform>().position += new Vector3(0f,-0.018f,0f);
        }
    }
}
