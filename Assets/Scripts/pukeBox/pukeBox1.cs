using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pukeBox1 : MonoBehaviour
{
    public Collider2D ObjectInPuke1;
    public pukeState pukeState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInPuke1 = activator;
        pukeState.puke.Add(ObjectInPuke1.tag);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(pukeState.puke.Contains(activator.tag))
            pukeState.puke.Remove(activator.tag);
            ObjectInPuke1 = null;
            }
      }
}
