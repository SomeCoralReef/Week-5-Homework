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
        ObjectInThree = activator;
        state.Letters.Add(ObjectInThree.tag);
        }
      }
     


      void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(state.Letters.Contains(activator.tag))
            state.Letters.Remove(activator.tag);
            ObjectInThree = null;
            }
      }
}