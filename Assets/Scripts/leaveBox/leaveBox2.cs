using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaveBox2 : MonoBehaviour
{
    public Collider2D ObjectInLeave2;
    public homeState leaveState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInLeave2 = activator;
        leaveState.leave.Add(ObjectInLeave2.tag);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(leaveState.leave.Contains(activator.tag))
            leaveState.leave.Remove(activator.tag);
            ObjectInLeave2 = null;
            }
      }
}