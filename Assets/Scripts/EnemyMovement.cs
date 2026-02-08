using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3f;  // Tốc độ xuống

    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        // Hủy nếu ra khỏi màn dưới (tránh lag)
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}