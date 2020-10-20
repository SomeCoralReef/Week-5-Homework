using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pukeBox3 : MonoBehaviour
{
    public Collider2D ObjectInPuke3;
    public pukeState pukeState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInPuke3 = activator;
        pukeState.puke.Add(ObjectInPuke3.tag);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(pukeState.puke.Contains(activator.tag))
            pukeState.puke.Remove(activator.tag);
            ObjectInPuke3 = null;
            }
      }
}
