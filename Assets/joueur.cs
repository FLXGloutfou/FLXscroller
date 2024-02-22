using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class joueur : MonoBehaviour
{
    public int health = 6;
    public int maxHealth = 6;
    public Text healthText;

    public Image healthBar;

    public Sprite healthbar_1;
    public Sprite healthbar_2;
    public Sprite healthbar_3;
    public Sprite healthbar_4;
    public Sprite healthbar_5;
    public Sprite healthbar_6;


    void Start()
    {
        UpdateHealthUI(health, maxHealth);
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Le personnage est mort !");
        if (health <= 0)
        {
            Die();
        }
        else if (health  == 6) 
        { 
            healthBar.sprite = healthbar_1;
        }
        else if (health == 5)
        {
            healthBar.sprite = healthbar_2;
        }
        else if (health == 4)
        {
            healthBar.sprite = healthbar_3;
        }
        else if (health == 3)
        {
            healthBar.sprite = healthbar_4;
        }
        else if (health == 2)
        {
            healthBar.sprite = healthbar_5;
        }
        else if (health == 1)
        {
            healthBar.sprite = healthbar_6;
        }


        UpdateHealthUI(health, maxHealth);
    }

    void Die()
    {
        Debug.Log("Le personnage est mort !");
    }

    // Rendre la fonction publique
    public void UpdateHealthUI(int currentHealth, int maxHealth)
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth + " / " + maxHealth;
        }
    }
}
