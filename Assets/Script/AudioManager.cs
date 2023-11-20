using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource MusicSource;
    public AudioClip Background;

    private void Start()
    {
        MusicSource.clip = Background;
        MusicSource.Play();
    }
}
