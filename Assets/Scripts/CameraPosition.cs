using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraPosition : MonoBehaviour
{
    public GameObject player;
    public GameObject testDummy;
    public GameObject yellowDummy;
    public GameObject redDummy;
    public GameObject blueDummy;
    public state state;
    public bool cameraShouldFollow = false;
    public bool inGoldState = false;
    public bool inWineState = false;
    public bool inHomeState = false;

    void start(){
    }
    void Update(){
        if(state.GoldWin == true){
            inGoldState = true;
            cameraShouldFollow = true;
            Vector3 position = yellowDummy.transform.position + new Vector3(0f,0f,2f);
            this.transform.position = player.transform.position;
            player.transform.position = position + new Vector3(0f,0f,1f);
            state.GoldWin = false;
            if(state.Letters.Contains("W")){
                state.Letters.Remove("W");
            } 
            if(state.Letters.Contains("I")){
                state.Letters.Remove("I");
            }
            if(state.Letters.Contains("N")){
                state.Letters.Remove("N");
            }
            if(state.Letters.Contains("S")){
                state.Letters.Remove("S");
            }
            if(state.Letters.Contains("G")){
                state.Letters.Remove("G");
            }
            if(state.Letters.Contains("O")){
                state.Letters.Remove("O");
            }
            if(state.Letters.Contains("L")){
                state.Letters.Remove("L");
            }
            if(state.Letters.Contains("D")){
                state.Letters.Remove("D");
            }
            
        }
        if(state.Home == true){
            inHomeState = true;
            cameraShouldFollow = true;
            Vector3 position = blueDummy.transform.position + new Vector3(0f,0f,2f);
            player.transform.position = position + new Vector3(0f,0f,1f);
            this.transform.position = player.transform.position;
            state.Home = false;
            if(state.Letters.Contains("H")){
                state.Letters.Remove("H");
            } 
            if(state.Letters.Contains("O")){
                state.Letters.Remove("O");
            }
            if(state.Letters.Contains("M")){
                state.Letters.Remove("M");
            }
            if(state.Letters.Contains("E")){
                state.Letters.Remove("E");
            }
        }
        if(state.Wine == true){
            inWineState = true;
            cameraShouldFollow = true;
            Vector3 position = redDummy.transform.position + new Vector3 (0f,0f,2f);
            player.transform.position = position + new Vector3(0f,0f,1f);
            this.transform.position = player.transform.position;
            state.Wine = false;
            if(state.Letters.Contains("W")){
                state.Letters.Remove("W");
            } 
            if(state.Letters.Contains("I")){
                state.Letters.Remove("I");
            }
            if(state.Letters.Contains("N")){
                state.Letters.Remove("N");
            }
            if(state.Letters.Contains("E")){
                state.Letters.Remove("E");
            }
        }

        if(Input.GetKey(KeyCode.Escape)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
         if(cameraShouldFollow == true){
            this.transform.position = player.transform.position + new Vector3 (0f,0f,-1f);
        }

    }
       

}
