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

    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        solCheck.position = new Vector3(transform.position.x, transform.position.y - 1.2f, transform.position.z);
        estAuSol = Physics2D.OverlapCircle(solCheck.position, 0.1f, solLayer);

        Deplacement();
        Saut();
        Debug.Log(Mathf.Abs(rb.velocity.x));
        // Envoyer la vitesse à l'Animator
        float characterVelocity = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("speed",characterVelocity);
    }
    private void FixedUpdate()
    {
        
    }
    void Deplacement()
    {
        float deplacementHorizontal = Input.GetAxis("Horizontal");
        Vector2 deplacement = new Vector2(deplacementHorizontal, 0);
        transform.Translate(deplacement * vitesseDeplacement * Time.deltaTime);

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
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * forceSaut, ForceMode2D.Impulse);
            sautsRestants--;
        }

        if (estAuSol)
        {
            sautsRestants = 1;
        }
    }
}
