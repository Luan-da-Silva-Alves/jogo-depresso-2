using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
   
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Encontre o SoundManager na cena (ou use uma referência global) e toque o som da porta.
            
            SoundManager.Instance.PlayDoorSound();
            
        }
    }
}
