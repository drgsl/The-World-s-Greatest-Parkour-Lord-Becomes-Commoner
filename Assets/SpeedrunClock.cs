using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// This is a Timer that can be used to track the time it takes to complete a level.
// It is a component that can be added to any GameObject in the scene.
public class SpeedrunClock : MonoBehaviour 
{
    // The time it takes to complete the level.
    private float time = 0f;
    // Whether or not the timer is running.
    private bool isRunning = false;

    // This is a reference to the TextMeshProUGUI component that displays the time.
    public TextMeshProUGUI timeText;


    public KeyCode PauseButton = KeyCode.Escape;

    private void Awake()
    {
        if(timeText)
            return;
        // Get the TextMeshProUGUI component from the children.
        timeText = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Start the timer.
        StartTimer();
    }


    // Update is called once per frame
    void Update()
    {
        // If the timer is running, add the time since the last frame to the total time.
        if (isRunning)
        {
            time += Time.deltaTime;
            timeText.text = GetTime();
        }

        if(Input.GetKeyDown(PauseButton))
            ToggleTimer();

    }

    
    // This method can be called to reset the timer.
    public void Reset()
    {
        time = 0f;
    }

    // This method can be called to stop the timer.
    public void Stop()
    {
        isRunning = false;
    }
public void ToggleTimer()
    {
        isRunning = !isRunning;
    }
    
    // This method can be called to start the timer.
    public void StartTimer()
    {
        isRunning = true;
    }

    // This method can be called to get the time in a formatted string.
    public string GetTime()
    {
        // Get the minutes and seconds from the total time.
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time - minutes * 60);
        // Get the milliseconds from the total time.
        int milliseconds = Mathf.FloorToInt((time * 1000) % 1000);
        // Return the time in a formatted string.
        return string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
}
