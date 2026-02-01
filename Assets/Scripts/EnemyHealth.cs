using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab;  // Kéo Explosion prefab (Particle System) vào đây

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))  // Chỉ xử lý khi trúng Bullet
        {
            // Destroy bullet NGAY TẠI ĐÂY (trước khi Die)
            Destroy(collision.gameObject);

            Die();  // Gọi Die để nổ + hủy enemy
        }
    }

    private void Die()
    {
        if (explosionPrefab != null)
        {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(explosion, 2f);  // Hủy explosion sau 2 giây (dài hơn duration particle ~1-1.5s)
        }

        Destroy(gameObject);  // Hủy enemy
    }
}