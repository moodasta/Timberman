using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class SFXAudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] sfxAudios;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip audio)
    {
        audioSource.clip = audio;
    }

}

