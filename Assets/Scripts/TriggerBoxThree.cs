using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxThree : MonoBehaviour
{
  public state state;
  public Collider2D ObjectInThree; 
  public bool letterInsert = false;

  
     void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
       letterInsert = true;
       ObjectInThree = activator;
       state.Letters.Add(ObjectInThree.tag); 
        Debug.Log(ObjectInThree);
      }
      }
     


      void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
            Debug.Log ("Nullified");
            state.Letters.Remove(ObjectInThree.tag);
            ObjectInThree = null;
            letterInsert = false;
            }
      }
}