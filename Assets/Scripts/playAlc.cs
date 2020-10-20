using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAlc : MonoBehaviour
{

    
    public AudioSource AlcAudio;
    public CameraPosition CameraPosition;
    // Start is called before the first frame update

    // Update is called once per frame
    
    void Start(){
    }
    
    void Update()
    {
        if(CameraPosition.inWineState == true){
            AlcAudio.Play();
            Debug.Log("should be in wine state");
        }
        if(AlcAudio.isPlaying == true){
            Debug.Log("AlcAudio should be playing");
        }
    }
}
