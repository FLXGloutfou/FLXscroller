using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int points = 1; 

    
    public delegate void OnCollectEvent(int collectedPoints);
    public static event OnCollectEvent OnCollect;

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
      
        // Informez l'UI de la collecte en déclenchant l'événement
        OnCollect?.Invoke(points);
    
        Destroy(gameObject);
    }
}
