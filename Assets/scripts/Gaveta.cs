using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaveta : MonoBehaviour
{
    public Animator AbrindoGaveta; // Refer�ncia para o componente Animator da gaveta.
    public AudioSource drawerSound; // Refer�ncia para o componente AudioSource do som da gaveta.

    private bool isOpen = false; // Verifica se a gaveta est� aberta.

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Inverte o estado da gaveta.
            isOpen = !isOpen;

            // Define o par�metro 'isOpen' no Animator para controlar a anima��o.
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
