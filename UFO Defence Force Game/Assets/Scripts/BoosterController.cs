using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterController : MonoBehaviour

{
    public float verticalInput;
    public GameObject boost; 
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 3.0f;
    private float spawnInterval = 3.0f;
    // Have booster randomly pop up
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnBooster", startDelay, spawnInterval);
    }

    void SpawnBooster()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(boost, spawnPos, boost.transform.rotation);
    }
} 
