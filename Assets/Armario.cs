using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetController : MonoBehaviour
{
    public Animator closetAnimator; // Reference to the closet door's Animator component.
    public AudioSource closetSound; // Reference to the AudioSource for the closet sound.

    private bool isClosetOpen = false; // Check if the closet is open.

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Check if the player enters the trigger zone.
        {
            if (!isClosetOpen)
            {
                // Open the closet door.
                closetAnimator.SetBool("IsOpen", true);
                isClosetOpen = true;

                // Play the closet sound.
                closetSound.Play();
            }
        }
    }
}

