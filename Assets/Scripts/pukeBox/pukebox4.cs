using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pukebox4 : MonoBehaviour
{
     public Collider2D ObjectInPuke4;
    public pukeState pukeState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInPuke4 = activator;
        pukeState.puke.Add(ObjectInPuke4.tag);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(pukeState.puke.Contains(activator.tag))
            pukeState.puke.Remove(activator.tag);
            ObjectInPuke4 = null;
            }
      }
}
