using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Controller : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public Image[] hearts;
    public GameObject gameoverpanel;
    public AudioSource gameoversound;
    


    private void Start()
    {
        currentHealth = maxHealth;
    }

    // Call this method when the player is hit by a meteoroid
    public void TakeDamage()
    {
        currentHealth--;

        // Update the heart images to reflect the current health
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHealth)
            {
                hearts[i].enabled = true; // enable heart image if it corresponds to a remaining health
            }
            else
            {
                hearts[i].enabled=false; // disable heart image if it corresponds to a lost health
            }
        }

        if (currentHealth <= 0)
        {
            // If the player has lost all their health, display the game over screen
            Time.timeScale = 0;
            gameoverpanel.SetActive(true);
            gameoversound.Play();
        }
    }
}
