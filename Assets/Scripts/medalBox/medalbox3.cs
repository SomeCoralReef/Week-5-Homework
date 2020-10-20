using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medalbox3 : MonoBehaviour
{
    public Collider2D ObjectInmedal3;
    public Goldstate medalState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInmedal3 = activator;
        medalState.medal.Add(ObjectInmedal3.tag);
        Debug.Log(ObjectInmedal3);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(medalState.medal.Contains(activator.tag))
            medalState.medal.Remove(activator.tag);
            ObjectInmedal3 = null;
            }
      }
}