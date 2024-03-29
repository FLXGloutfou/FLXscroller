using UnityEngine;

public class Autoenemis : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;
    private Transform target;
    private int desPoint = 0;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        Debug.Log("Enemy script attached to: " + gameObject.name);
        target = waypoints[0];
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            desPoint = (desPoint + 1) % waypoints.Length;
            target = waypoints[desPoint];

            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
    }

    public int damageAmount = 1;
    public float repelForce = 5f; 

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Causer des d�g�ts au joueur
            collision.gameObject.GetComponent<joueur>().TakeDamage(damageAmount);

            // Repousser le joueur
            Vector2 repelDirection = (collision.transform.position - transform.position).normalized;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(repelDirection * repelForce, ForceMode2D.Impulse);
        }
    }
}