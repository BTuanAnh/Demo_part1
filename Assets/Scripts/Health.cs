using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;  // Kéo prefab explosion (enemy/player riêng)
    public int defaultHealthPoint = 1;  // Enemy =1, player override =3-5

    private int currentHealthPoint;

    private void Awake()
    {
        currentHealthPoint = defaultHealthPoint;
    }

    public virtual void TakeDamage(int damageAmount)
    {
        currentHealthPoint -= damageAmount;

        if (currentHealthPoint <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(explosion, 2f);
        }

        Destroy(gameObject);
    }
}