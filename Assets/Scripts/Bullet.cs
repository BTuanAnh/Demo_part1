using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 30f;
    public int damage = 1;  // Damage gây (Inspector chỉnh, enemy chịu nhiều hit)

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.velocity = Vector2.up * flySpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Gây damage cho bất kỳ object có Health (enemy hoặc player nếu test)
        Health health = collision.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage);
        }

        Destroy(gameObject);  // Bullet luôn hủy khi trúng
    }

    // Bonus: Hủy ra màn trên (tránh lag)
    private void Update()
    {
        if (transform.position.y > 10f)
        {
            Destroy(gameObject);
        }
    }
}
