using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medalbox1 : MonoBehaviour
{
    public Collider2D ObjectInmedal1;
    public Goldstate medalState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInmedal1 = activator;
        medalState.medal.Add(ObjectInmedal1.tag);
        Debug.Log(ObjectInmedal1);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(medalState.medal.Contains(activator.tag))
            medalState.medal.Remove(activator.tag);
            ObjectInmedal1 = null;
            }
      }
}