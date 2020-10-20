using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxFour : MonoBehaviour
{
  public state state;
  public Collider2D ObjectInFour; 
  public bool letterInsert = false;

  
 void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInFour = activator;
        state.Letters.Add(ObjectInFour.tag);
        }
      }
     


      void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(state.Letters.Contains(activator.tag))
            state.Letters.Remove(activator.tag);
            ObjectInFour = null;
            }
      }
}