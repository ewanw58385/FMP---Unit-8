using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameTimer : MonoBehaviour
{

    public float timeRemaining = 10;
    public bool timerIsRunning = false;

    public float minutes;
    public float seconds; 


    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }

        float seconds = Mathf.FloorToInt(timeRemaining / 60);
        float minutes = Mathf.FloorToInt(timeRemaining % 60);
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
    }

}
