using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour


{

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public static SoundManager Instance; // Refer�ncia est�tica para o gerenciador de som.

    public AudioSource doorSound; // Refer�ncia para o componente AudioSource do som da porta.

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayDoorSound()
    {
        doorSound.Play();
    }
}
