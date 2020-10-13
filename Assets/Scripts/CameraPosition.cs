using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraPosition : MonoBehaviour
{
    public GameObject redbox;
    public state state;

    void start(){
    }
    void Update(){
        if(state.GoldWin == true){
            Vector3 position = redbox.transform.position + new Vector3(0f,0f,2f);
            this.transform.position = position;
        }
        if(Input.GetKey(KeyCode.Escape)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    


}
