using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaveBox5 : MonoBehaviour
{
    public Collider2D ObjectInLeave5;
    public homeState leaveState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInLeave5 = activator;
        leaveState.leave.Add(ObjectInLeave5.tag);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(leaveState.leave.Contains(activator.tag))
            leaveState.leave.Remove(activator.tag);
            ObjectInLeave5 = null;
            }
      }
}
