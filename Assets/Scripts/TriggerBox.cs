using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBox : MonoBehaviour
{
  public state state;
  public Collider2D ObjectInOne; 
  
     void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInOne = activator;
        state.Letters.Add(ObjectInOne.tag);
        }
      }
     


      void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(state.Letters.Contains(activator.tag))
            state.Letters.Remove(activator.tag);
            }
      }

    
    void Update(){
          
    }
  
}

