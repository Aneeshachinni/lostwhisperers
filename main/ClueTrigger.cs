using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueTrigger : MonoBehaviour
{

    public string message = "You're close to your child!"; // Message to display
    public TextMeshProUGUI messageText; // UI object to display the message (assign in Inspector)

    // Start is called before the first frame update
    void Start()
    {
        // To ensure the message UI is hidden at the start
        messageText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the collider is the player
        {
             messageText.text = message; // Set the message text to be displayed
             messageText.gameObject.SetActive(true); // Show the message on screen
        }
    }

    // This is called when the player exits the trigger zone
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            messageText.gameObject.SetActive(false); // Hide the message when the player leaves the area
        }
    }
}
