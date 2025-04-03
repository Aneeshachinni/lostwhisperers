using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public float timeRemaining = 60f; // 1 minute timer
    public TextMeshProUGUI timerText; // Link with UI text (TextMeshPro component)
    private bool timerIsRunning = false; // Flag to track if the timer is running

    // Start is called before the first frame update
    void Start()
    {
        //Start the timer when the game starts
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                // Decrease the time and update UI
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                // Timer ran out
                timeRemaining = 0;
                timerIsRunning = false; // Stop the timer
                EndGame(); // Call end game logic
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        // Ensure no negative time
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        // Format the time in minutes and seconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); // Get minutes
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // Get seconds

        // Check if the UI text is assigned and update it
        if (timerText != null)
        {
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    void EndGame()
    {
        // Game over logic here
        Debug.Log("Time's up! You couldn't find your child.");
    }
}
