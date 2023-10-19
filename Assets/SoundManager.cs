using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour


{

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public static SoundManager Instance; // Referência estática para o gerenciador de som.

    public AudioSource doorSound; // Referência para o componente AudioSource do som da porta.

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
