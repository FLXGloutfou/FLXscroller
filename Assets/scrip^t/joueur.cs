using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class joueur : MonoBehaviour
{
    public int health = 3;
    public int maxHealth = 3;
  

    public Image healthBar;

    public Sprite healthbar_0;
    public Sprite healthbar_1;
    public Sprite healthbar_2;
    public Sprite healthbar_3;



    void Start()
    {
        
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Le personnage est mort !");
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



    }

    void Die()
    {
        healthBar.sprite = healthbar_0;
        Debug.Log("Le personnage est mort !");
    }
}


