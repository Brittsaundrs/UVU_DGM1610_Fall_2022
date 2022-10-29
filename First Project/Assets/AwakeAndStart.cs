using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    // Awake is called before Start
    void Awake()
    {
        Debug.Log("Awake called.");
    }

    // Start is called once per code lifetime
    void Start()
    {
        Debug.Log("Start called.");
    }
    // Awake kind of sets up the stage before actually playing.
}
