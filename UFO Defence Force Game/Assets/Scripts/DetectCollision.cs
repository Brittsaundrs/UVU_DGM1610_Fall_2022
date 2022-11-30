using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // Store reference to score manager
    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>(); // Find ScoreManager gameobject and reference ScoreManager script component
    }

    void OnTriggerEnter(Collider other) // Once Trigger has been entered record collision in "other"
    {
        scoreManager.IncreaseScore(scoreToGive); // Increase the Score
        Destroy(gameObject); // Destroy this gameobject
        Destroy(other.gameObject); // Destroy gameobject collided with
    }
}
