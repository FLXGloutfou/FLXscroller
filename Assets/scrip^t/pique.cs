using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pique : MonoBehaviour
{
    
    public int damageAmount = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            collision.gameObject.GetComponent<joueur>().TakeDamage(damageAmount);
        }
    }

}
