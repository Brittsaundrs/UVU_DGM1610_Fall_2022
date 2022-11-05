using UnityEngine;
using System.Collections;

public class DebugTimer : MonoBehaviour
// Debug timer
{
    float currentTime = 0f;
    float startingTime = 10f;
    string timeLastFrame = "0";
    //will help avoid decimals

    void Start()
    // sets start time to 0
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        if(timeLastFrame != currentTime.ToString("f0"))
        {
            timeLastFrame = currentTime.ToString("f0");
        }
        if(currentTime <= 0)
        {
            currentTime = 0;
            Debug.Log("Time's out!");
            enabled = false;
        }
    }
}
/* NOTE: Time.deltaTime helps keep things at a constant speed 
regardless of the framerate*/