﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pukeState : MonoBehaviour
{
public List<string> puke = new List<string> {};
public GameObject alc_8;
public bool pukeSound = false;
float numberToInstantiate = 1;

void Update (){
    if(puke.Contains("P") && puke.Contains("U") && puke.Contains("K") && puke.Contains("E")){
        if(numberToInstantiate > 0 ){
        Instantiate(alc_8);
        pukeSound = true;
        numberToInstantiate --;
        }


    }
}

}
