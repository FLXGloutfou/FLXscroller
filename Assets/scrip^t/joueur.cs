using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class joueur : MonoBehaviour
{
    public int health = 3;
    public int maxHealth = 3;
    public float invulnerabilityDuration = 1f; // Durée d'invulnérabilité en secondes

    public Image healthBar;
    public Sprite healthbar_0;
    public Sprite healthbar_1;
    public Sprite healthbar_2;
    public Sprite healthbar_3;

    public Transform respawnPoint;

    private bool isInvulnerable = false; // Indique si le joueur est actuellement invulnérable

    void Start()
    {
        respawnPoint = GameObject.Find("RespawnPoint").transform;
    }

    public void TakeDamage(int damageAmount)
    {
        if (!isInvulnerable)
        {
            health -= damageAmount;

            if (health <= 0)
            {
                Die();
            }
            else if (health == 3)
            {
                healthBar.sprite = healthbar_3;
            }
            else if (health == 2)
            {
                healthBar.sprite = healthbar_2;
            }
            else if (health == 1)
            {
                healthBar.sprite = healthbar_1;
            }

            // Activer la période d'invulnérabilité
            StartCoroutine(InvulnerabilityPeriod());
        }
    }

    IEnumerator InvulnerabilityPeriod()
    {
        isInvulnerable = true;

        // Attendre la durée d'invulnérabilité
        yield return new WaitForSeconds(invulnerabilityDuration);

        isInvulnerable = false;
    }

    void Die()
    {
        healthBar.sprite = healthbar_0;
        Debug.Log("Le personnage est mort !");

        // Réinitialiser la vie
        health = maxHealth;

        // Placer le joueur à la position de respawn
        transform.position = respawnPoint.position;

        healthBar.sprite = healthbar_3;
    }
}
