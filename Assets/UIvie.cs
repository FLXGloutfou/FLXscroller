using UnityEngine;
using UnityEngine.UI;

public class Uivie : MonoBehaviour
{
    public Text healthText;
    public Image healthBar;
    public Image healthImage; // Assurez-vous d'attacher une Image dans l'Inspector
    public joueur scriptJoueur;
    public Sprite[] healthSprites; // Tableau des sprites de santé

    // Fonction pour mettre à jour l'UI avec les points de vie
    public void UpdateHealthUI(int currentHealth, int maxHealth)
    {
        float healthPercentage = (float)currentHealth / maxHealth;

        // Mettre à jour le texte
        healthText.text = "Health: " + currentHealth + " / " + maxHealth;

        // Mettre à jour la barre de vie
        healthBar.fillAmount = healthPercentage;

        // Mettre à jour l'image de la vie en utilisant les sprites
        int spriteIndex = Mathf.FloorToInt(healthPercentage * healthSprites.Length);
        spriteIndex = Mathf.Clamp(spriteIndex, 0, healthSprites.Length - 1);
        healthImage.sprite = healthSprites[spriteIndex];
    }
}
