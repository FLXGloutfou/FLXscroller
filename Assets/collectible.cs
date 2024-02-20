using UnityEngine;

public class collectible : MonoBehaviour
{
    public int points = 10; // Points attribués au joueur lorsqu'il collecte cet objet

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Le joueur a collecté l'objet, vous pouvez ajouter ici toute logique supplémentaire
            Collect();
        }
    }

    void Collect()
    {
        // Ajoutez ici le code que vous souhaitez exécuter lorsque le joueur collecte l'objet
        // Par exemple, vous pouvez ajouter des points au score du joueur

        // Détruisez l'objet collectible après qu'il a été collecté
        Destroy(gameObject);
    }
}
