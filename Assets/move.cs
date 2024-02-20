using UnityEngine;

public class move : MonoBehaviour
{
    public float vitesseDeplacement = 5f;
    public float forceSaut = 10f;
    public Transform solCheck;
    public LayerMask solLayer;

    private bool estAuSol;
    private int sautsRestants = 2;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Mise à jour de la position de solCheck pour suivre le personnage
        solCheck.position = new Vector3(transform.position.x, transform.position.y - 1.2f, transform.position.z);

        estAuSol = Physics2D.OverlapCircle(solCheck.position, 0.1f, solLayer);

        Deplacement();
        Saut();
    }
    void Deplacement()
    {
        float deplacementHorizontal = Input.GetAxis("Horizontal");
        Vector2 deplacement = new Vector2(deplacementHorizontal, 0);
        transform.Translate(deplacement * vitesseDeplacement * Time.deltaTime);

        // Change la direction du personnage en fonction de la direction du déplacement
        if (deplacementHorizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (deplacementHorizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    void Saut()
    {
        if (Input.GetButtonDown("Jump") && (estAuSol || sautsRestants > 0))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0); // Réinitialise la vitesse verticale

            rb.AddForce(Vector2.up * forceSaut, ForceMode2D.Impulse);
            sautsRestants--;
        }

        // Reset le nombre de sauts disponibles lorsque le personnage touche le sol
        if (estAuSol)
        {
            sautsRestants = 1;
        }
    }
}
