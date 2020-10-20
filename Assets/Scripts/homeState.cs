using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeState : MonoBehaviour
{
public List<string> leave = new List<string> {};
public GameObject leavePreFab;
float numberToInstantiate = 1;
void Update (){
    if(leave.Contains("G") && leave.Contains("O") && leave.Contains("N") && leave.Contains("E")){
        if(numberToInstantiate >0){
            Instantiate(leavePreFab);
            numberToInstantiate -= 1;
        }
        
    }
}
}
