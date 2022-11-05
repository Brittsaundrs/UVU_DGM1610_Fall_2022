using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomSpawn : MonoBehaviour 
// will spawn cube in random location every few seconds
//cube should disappear once it hits the floor
// I think the disappearing should work with another script
{
    public GameObject target;
    public float Timer = 2;

    void Start()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10,11), 5, Random.Range(-10, 11));
        Instantiate(target, randomSpawnPosition, Quaternion.identity);
        // quaternion identity means no rotation
    }
}