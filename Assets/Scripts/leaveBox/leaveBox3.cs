using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaveBox3 : MonoBehaviour
{
    public Collider2D ObjectInLeave3;
    public homeState leaveState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInLeave3 = activator;
        leaveState.leave.Add(ObjectInLeave3.tag);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(leaveState.leave.Contains(activator.tag))
            leaveState.leave.Remove(activator.tag);
            ObjectInLeave3 = null;
            }
      }
}