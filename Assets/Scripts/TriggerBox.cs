using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBox : MonoBehaviour
{
  public state state;
  public Collider2D ObjectInOne; 
  public bool letterInsert = false;

  
     void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
       letterInsert = true;
       ObjectInOne = activator;
       state.Letters.Add(ObjectInOne.tag); 
        Debug.Log(ObjectInOne);
      }
     }
     


      void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
            Debug.Log ("Nullified");
            state.Letters.Remove(ObjectInOne.tag);
            ObjectInOne = null;
            letterInsert = false;
            }
      }

    
    void Update(){
          
    }
  
}

