using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medalbox5 : MonoBehaviour
{
    public Collider2D ObjectInmedal5;
    public Goldstate medalState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInmedal5 = activator;
        medalState.medal.Add(ObjectInmedal5.tag);
        Debug.Log(ObjectInmedal5);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(medalState.medal.Contains(activator.tag))
            medalState.medal.Remove(activator.tag);
            ObjectInmedal5 = null;
            }
      }
}