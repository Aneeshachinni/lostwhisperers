using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostCollision : MonoBehaviour
{

    public AudioSource shoutSound; // Reference to the ghost's AudioSource
   
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
        // Check if the player is the object colliding with the ghost
        if (other.CompareTag("Player"))
        {
            // Play the shout sound
            if (shoutSound != null)
            {
                shoutSound.Play();
            }
        }
}
}