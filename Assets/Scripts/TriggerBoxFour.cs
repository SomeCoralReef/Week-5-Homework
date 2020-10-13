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
       letterInsert = true;
       ObjectInFour = activator;
       state.Letters.Add(ObjectInFour.tag); 
        Debug.Log(ObjectInFour);
      }
      }
     


      void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
            Debug.Log ("Nullified");
            state.Letters.Remove(ObjectInFour.tag);
            ObjectInFour = null;
            letterInsert = false;
            }
      }
}