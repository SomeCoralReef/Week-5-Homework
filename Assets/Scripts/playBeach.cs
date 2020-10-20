using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playBeach : MonoBehaviour
{
    public AudioSource BeachAudio;
    public AudioSource AlcAudio;
    public AudioSource pukeSound;
    public AudioSource goldAudio;
    public AudioSource homeAudio;
    public AudioSource seagullSounds;
    public AudioSource waveSounds;
    public CameraPosition CameraPosition;
    public pukeState pukeState;
    public bool touchedbyBird = false;
    float playCount = 1;
    float pukePlayCount = 1;
    float goldPlayCount = 1;
    float homePlayCount = 1;
    void Start()
    {
        BeachAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(CameraPosition.inWineState == true && playCount > 0 ){
            BeachAudio.Pause();
            AlcAudio.Play();
            playCount--;
        }
         if(pukeState.pukeSound == true && pukePlayCount > 0){
             AlcAudio.Pause();
             pukeSound.Play();
             pukePlayCount--;
      
         }

         if(CameraPosition.inGoldState == true && goldPlayCount > 0){
             BeachAudio.Pause();
             goldAudio.Play();
             goldPlayCount--;
               Debug.Log("should i be here?");
         }

         if(CameraPosition.inHomeState == true && homePlayCount > 0){
             BeachAudio.Pause();
             homeAudio.Play();
             homePlayCount--;
         }
         if(touchedbyBird == true){
             seagullSounds.PlayOneShot(seagullSounds.clip,1f);
         }
    }
}
