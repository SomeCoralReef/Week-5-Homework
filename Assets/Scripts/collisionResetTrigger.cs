using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionResetTrigger : MonoBehaviour

{

public playBeach playBeach;
    void OnTriggerEnter2D(Collider2D activator){
        if(activator.tag == "Player"){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
