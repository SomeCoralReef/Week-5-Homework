using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medalbox4 : MonoBehaviour
{
    public Collider2D ObjectInmedal4;
    public Goldstate medalState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInmedal4 = activator;
        medalState.medal.Add(ObjectInmedal4.tag);
        Debug.Log(ObjectInmedal4);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(medalState.medal.Contains(activator.tag))
            medalState.medal.Remove(activator.tag);
            ObjectInmedal4 = null;
            }
      }
}