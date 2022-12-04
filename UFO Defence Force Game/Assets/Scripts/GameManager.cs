using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;
    AudioSource gameOverAudio;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
        gameOverAudio = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("Game Over Text"); 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver) // Shorthand for  if(isGameOver == true)
        {
            EndGame(); // Calls EndGame() method/function
        }
        else
        {
            gameOverText.gameObject.SetActive(false); // Keep UI Game Over text hidden
        }
    }

    public void EndGame()
    {
        gameOverAudio.Play();
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0; // Freeze time
    }
}
