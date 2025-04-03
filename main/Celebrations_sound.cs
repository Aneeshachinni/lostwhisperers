using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celebrations_sound : MonoBehaviour
{
    public AudioSource celebrationSound;  // Assign celebratory sound here
    //public ParticleSystem fireworksEffect; // Assign the fireworks particle system here
    public GameObject fireworksGameObject; 

    private bool celebrationTriggered = false; // Ensure the celebration only happens once

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        // Check if the player collides with the child
        if (other.CompareTag("Player") && !celebrationTriggered)
        {
            Debug.Log("Player collided with child!");  // Log for debugging purposes

            // Trigger celebration only once
            celebrationTriggered = true;

            // Play the celebratory sound if assigned
            if (celebrationSound != null)
            {
                celebrationSound.Play();
            }

            // Trigger the fireworks effect if assigned
            if (fireworksGameObject != null)
            {
                fireworksGameObject.SetActive(true);  // This activates the fireworks GameObject
            }
        }
    }
    
 }


