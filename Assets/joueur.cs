using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class joueur : MonoBehaviour
{
    public int health = 100;
    public int maxHealth = 100;
    public Text healthText;

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
        else
        {
            // Actions suppl�mentaires lors de la r�ception de d�g�ts
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
