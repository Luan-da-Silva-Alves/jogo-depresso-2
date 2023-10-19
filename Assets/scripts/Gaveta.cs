using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaveta : MonoBehaviour
{
    public Animator AbrindoGaveta; // Referência para o componente Animator da gaveta.
    public AudioSource drawerSound; // Referência para o componente AudioSource do som da gaveta.

    private bool isOpen = false; // Verifica se a gaveta está aberta.

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Inverte o estado da gaveta.
            isOpen = !isOpen;

            // Define o parâmetro 'isOpen' no Animator para controlar a animação.
            AbrindoGaveta.SetBool("isOpen", isOpen);

            // Toca o som da gaveta.
            if (isOpen)  
            {
                drawerSound.Play();
            }
            else
            {
                drawerSound.Play();
            }
        }
    }
}
