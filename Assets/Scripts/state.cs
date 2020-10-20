
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state : MonoBehaviour
{   
    public bool GoldWin = false;
    public bool Home = false;
    public bool Wine = false;
    public List<string> Letters = new List<string> {};
    public TriggerBox TriggerBox;
    public TriggerBoxTwo TriggerBoxTwo;
    public TriggerBoxThree TriggerBoxThree;
    public TriggerBoxFour TriggerBoxFour;
    void Update(){
       if(Letters.Contains("W") && Letters.Contains("I") && Letters.Contains("N") && Letters.Contains("S")){
           GoldWin = true;
       } 
        if(Letters.Contains("G") && Letters.Contains("O") && Letters.Contains("L") && Letters.Contains("D")){
            GoldWin = true;
         }
        if(Letters.Contains("H") && Letters.Contains("O") && Letters.Contains("M")&& Letters.Contains("E")){
            Home = true;
        }
         if(Letters.Contains("W") && Letters.Contains("I") && Letters.Contains("N")&& Letters.Contains("E")){
            Wine = true;
        }
    }
}   
