using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// program controls player
public class Controller : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    // no need to make public, but it'll be used in Inspector.

    private float maxHealth = 250f;
    private float currentHealth;
    //NOTE: could also use ints.

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            currentHealth -= 15f;
            UpdateHealthBar();
        }
    }
    
    private void UpdateHealthBar()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}
