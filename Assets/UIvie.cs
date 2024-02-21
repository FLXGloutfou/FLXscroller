using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Text healthText;
    public Image healthBar;
    public joueur scriptJoueur;

    // Fonction pour mettre � jour l'UI avec les points de vie
    public void UpdateHealthUI(int currentHealth, int maxHealth)
    {
        float healthPercentage = (float)currentHealth / maxHealth;

        // Mettre � jour le texte
        healthText.text = "Health: " + currentHealth + " / " + maxHealth;

        // Mettre � jour la barre de vie
        healthBar.fillAmount = healthPercentage;
    }
}
