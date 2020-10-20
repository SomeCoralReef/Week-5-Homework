using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaveBox : MonoBehaviour
{
    public Collider2D ObjectInLeave1;
    public homeState leaveState;
    void OnTriggerEnter2D (Collider2D activator){
      if(activator.tag != "Player"){
        ObjectInLeave1 = activator;
        leaveState.leave.Add(ObjectInLeave1.tag);
        Debug.Log(ObjectInLeave1);
        }
      }

     void OnTriggerExit2D (Collider2D activator){
       if(activator.tag != "Player"){
         if(leaveState.leave.Contains(activator.tag))
            leaveState.leave.Remove(activator.tag);
            ObjectInLeave1 = null;
            }
      }
}
