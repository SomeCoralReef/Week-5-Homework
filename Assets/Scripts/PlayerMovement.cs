using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    Rigidbody2D myRigidbody;
    float inputHorizontal;
    float inputVertical;
    public float MoveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");
    }
    void FixedUpdate(){
        myRigidbody.velocity = new Vector2 ( inputHorizontal * MoveSpeed, inputVertical * MoveSpeed);
    }
}
