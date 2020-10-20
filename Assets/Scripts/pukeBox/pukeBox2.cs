using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pukeBox2 : MonoBehaviour
{
     public Collider2D ObjectInPuke2;
    public pukeState pukeState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInPuke2 = activator;
        pukeState.puke.Add(ObjectInPuke2.tag);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(pukeState.puke.Contains(activator.tag))
            pukeState.puke.Remove(activator.tag);
            ObjectInPuke2 = null;
            }
      }
}
