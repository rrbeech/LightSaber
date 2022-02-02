using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaber : MonoBehaviour
{
    public Animator LightSaberAnimator;
    public AudioSource audioSource;
    public AudioSource audioSourceAux;
    public AudioClip hum;
    public AudioClip powerUp;
    public AudioClip powerDown;

    public void turnOnLightSaber()
    {
        LightSaberAnimator.SetTrigger("Turn Light Saber ON");
        LightSaberAnimator.ResetTrigger("Turn Light Saber OFF"); // Reset trigger

        audioSource.PlayOneShot(hum); //play the steady hum
        audioSourceAux.PlayOneShot(powerUp); //play the powerup
    }

    public void turnOFFLightSaber()
    {
        LightSaberAnimator.SetTrigger("Turn Light Saber OFF");
        LightSaberAnimator.ResetTrigger("Turn Light Saber ON"); //Reset trigger

        audioSource.Stop();//turn off hum
        audioSourceAux.PlayOneShot(powerDown);
    
      
    }

}
