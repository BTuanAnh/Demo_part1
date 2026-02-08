using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damageToPlayer = 1;  // Damage gây player khi chạm

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damageToPlayer);

            // Enemy tự suicide (chết ngay)
            GetComponent<EnemyHealth>().TakeDamage(999);  // Hoặc lớn hơn max health
        }
    }
}