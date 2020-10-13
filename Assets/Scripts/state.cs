
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state : MonoBehaviour
{
    public bool GoldWin = false;
    public List<string> Letters = new List<string> {};
    public TriggerBox TriggerBox;
    public TriggerBoxTwo TriggerBoxTwo;
    public TriggerBoxThree TriggerBoxThree;
    public TriggerBoxFour TriggerBoxFour;
    void Update(){
       if(Letters.Contains("W") && Letters.Contains("I") && Letters.Contains("N") && Letters.Contains("S")){
           Debug.Log("WINS");
           GoldWin = true;
       } 
        if(Letters.Contains("G") && Letters.Contains("O") && Letters.Contains("L") && Letters.Contains("D")){
           Debug.Log("GOLD");
            GoldWin = true;
         }
    }
}   

//     if(TriggerBox.letterInsert == true && TriggerBoxTwo.letterInsertTwo == true && TriggerBoxThree.letterInsertThree == true && TriggerBoxFour.letterInsertFour == true){
    //         if(TriggerBox.ObjectInOne.tag == "W"){
    //             if(TriggerBoxTwo.ObjectInTwo.tag == "I"){
    //                  if(TriggerBoxThree.ObjectInThree.tag == "N"){
    //                      if(TriggerBoxFour.ObjectInFour.tag == "S"){
    //                             Debug.Log("STATE CHANGE TO WIN");
    //                       }
    //                 }
    //             }
    //         }
    //     }
    // }