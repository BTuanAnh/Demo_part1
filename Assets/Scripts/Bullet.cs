using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 30f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.velocity = Vector2.up * flySpeed; // bay lên
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
