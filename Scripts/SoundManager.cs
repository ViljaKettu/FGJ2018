using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{

    public AudioSource correctSound;
    public AudioSource wrongSound;
    public AudioSource musicSource;
    public AudioSource package;


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        correctSound = GetComponent<AudioSource>();
        wrongSound = GetComponent<AudioSource>();
        musicSource = GetComponent<AudioSource>();

    }

    public void PlayCorrect()
    {
        correctSound.Play();
    }
    public void PlayWrong()
    {
        wrongSound.Play();
    }

    public void DropPackage()
    {
        package.Play();
    }
}
