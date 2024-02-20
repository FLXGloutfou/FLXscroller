using UnityEngine;

public class collectible : MonoBehaviour
{
    public int points = 10; // Points attribu�s au joueur lorsqu'il collecte cet objet

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Le joueur a collect� l'objet, vous pouvez ajouter ici toute logique suppl�mentaire
            Collect();
        }
    }

    void Collect()
    {
        // Ajoutez ici le code que vous souhaitez ex�cuter lorsque le joueur collecte l'objet
        // Par exemple, vous pouvez ajouter des points au score du joueur

        // D�truisez l'objet collectible apr�s qu'il a �t� collect�
        Destroy(gameObject);
    }
}
