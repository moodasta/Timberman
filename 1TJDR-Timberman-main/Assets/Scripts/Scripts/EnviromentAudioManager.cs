using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentAudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] enviromentAudios;
    private AudioSource audioSource;


    void Awake()
    {
       audioSource = GetComponent<AudioSource>(); 
    }

    public void Playsound(AudioClip audio)
    {
        audioSource.clip = audio;
        audioSource.Play();
    }
}
