﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winsWanderScript : MonoBehaviour
{
    public CameraPosition CameraPosition;
    void Update(){
        if(CameraPosition.inGoldState == true){
             //always move "forward" (move along its X axis*red arrow))
            transform.Translate(2f * Time.deltaTime,0f,0f); // move 2m per second
        //raycast in front of us and randomly turn left or right if there's a wall
            Ray2D myRay = new Ray2D (transform.position, transform.right);
            float myMaxRayDist = 1.8f;
          Debug.DrawRay(myRay.origin, myRay.direction * myMaxRayDist, Color.blue);
        
         RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myMaxRayDist);

        // did the raycast hit something?
             if (myRayHit.collider != null){
                float randomNumber = Random.Range (0,100);
                transform.Rotate(0f,0f,randomNumber);
        }
        }
    }
    void OnTriggerEnter2D (Collider2D activator){
        Debug.Log("lets go");
    }
}