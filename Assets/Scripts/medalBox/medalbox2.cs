using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medalbox2 : MonoBehaviour
{
    public Collider2D ObjectInmedal2;
    public Goldstate medalState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInmedal2 = activator;
        medalState.medal.Add(ObjectInmedal2.tag);
        Debug.Log(ObjectInmedal2);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(medalState.medal.Contains(activator.tag))
            medalState.medal.Remove(activator.tag);
            ObjectInmedal2 = null;
            }
      }
}