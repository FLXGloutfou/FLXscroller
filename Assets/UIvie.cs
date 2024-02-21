using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Text healthText;
    public Image healthBar;
    public joueur scriptJoueur;

    // Fonction pour mettre à jour l'UI avec les points de vie
    public void UpdateHealthUI(int currentHealth, int maxHealth)
    {
        float healthPercentage = (float)currentHealth / maxHealth;

        // Mettre à jour le texte
        healthText.text = "Health: " + currentHealth + " / " + maxHealth;

        // Mettre à jour la barre de vie
        healthBar.fillAmount = healthPercentage;
    }
}
