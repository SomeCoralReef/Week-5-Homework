using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goldstate : MonoBehaviour
{
public List<string> medal = new List<string> {};
public GameObject medalPreFab;
float numberToInstantiate = 1;
void Update (){
    if(medal.Contains("M") && medal.Contains("E") && medal.Contains("D") && medal.Contains("A") && medal.Contains("L")){
        if(numberToInstantiate >0){
            Instantiate(medalPreFab);
            numberToInstantiate -= 1;
        }
        
    }
}

}

