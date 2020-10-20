using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaveBox4 : MonoBehaviour
{
    public Collider2D ObjectInLeave4;
    public homeState leaveState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInLeave4 = activator;
        leaveState.leave.Add(ObjectInLeave4.tag);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(leaveState.leave.Contains(activator.tag))
            leaveState.leave.Remove(activator.tag);
            ObjectInLeave4 = null;
            }
      }
}