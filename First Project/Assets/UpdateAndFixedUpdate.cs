using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    // Any necessary physics calculation are made here
    // Use forces for movement
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time: " + Time.deltaTime);
    }

    // Update is called once per frame
    // Anything that needs to be regularly changed/adjusted
    // Simple timers, input, or moving objects
    // Not called on a regular timeline
    void Update()
    {
       Debug.Log("Update time: " + Time.deltaTime); 
    }
}
