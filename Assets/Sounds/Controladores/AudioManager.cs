using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   [SerializeField] private AudioSource audioSourceSfx;
   [SerializeField] private AudioSource audioSourceMusic;
   

    


    public void ReproducirSonido(AudioClip clip)
    {
        audioSourceSfx.PlayOneShot(clip);
    } 
    public void ReproducirMusica()
    {
        audioSourceMusic.Play();
    } 
    
    public void ReproducirAudioSource(AudioSource audioSource)
    {
        audioSource.PlayOneShot(audioSource.clip);
    }
   
}
