using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxTwo : MonoBehaviour
{
  public state state;
  public Collider2D ObjectInTwo; 
  public bool letterInsert = false;

  
     void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
       letterInsert = true;
       ObjectInTwo = activator;
       state.Letters.Add(ObjectInTwo.tag); 
        Debug.Log(ObjectInTwo);
      }
      }
     


      void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
            Debug.Log ("Nullified");
            state.Letters.Remove(ObjectInTwo.tag);
            ObjectInTwo = null;
            letterInsert = false;
            }
      }
}