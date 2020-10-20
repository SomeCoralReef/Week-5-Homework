 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

 public class resetpos : MonoBehaviour
 {   
     public GameObject player;
     public GameObject redDummy;
     // Start is called before the first frame update
     void OnTriggerExit2D(Collider2D activator){
         Debug.Log("Should reset");
         if(activator.tag == "player"){
             player.transform.position = redDummy.transform.position;
         }

     }
 }
