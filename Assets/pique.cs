using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pique : MonoBehaviour
{
    // Dans le script de l'ennemi
    public int damageAmount = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Si le joueur entre en collision avec l'ennemi, infligez des dégâts au joueur
            collision.gameObject.GetComponent<joueur>().TakeDamage(damageAmount);
        }
    }

}
