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
        ObjectInTwo = activator;
        state.Letters.Add(ObjectInTwo.tag);
        }
      }
     


      void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(state.Letters.Contains(activator.tag))
            state.Letters.Remove(activator.tag);
            ObjectInTwo = null;
            }
      }
}