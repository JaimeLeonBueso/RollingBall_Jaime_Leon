using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField] AudioClip clipEnUso;
    [SerializeField] AudioSource audioSource;

    public void CambiarClipSFX(AudioClip audioClip)
    {
    clipEnUso = audioClip;
    audioSource.clip = clipEnUso;
    }
 
}

public class ComponentesSonidos : ScriptableObject
{
    [SerializeField] AudioClip clip;
    [SerializeField] bool PlayOnAwake;
    [SerializeField] bool loop;
    [SerializeField] float volume;

}
