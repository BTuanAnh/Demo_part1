using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval = 0.2f;  // Khoảng cách bắn (giây)

    private float lastBulletTime;  // Thời gian bắn lần cuối

    void Update()
    {
        if (Input.GetMouseButton(0))  // GIỮ chuột trái
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, 0.5f, 0);  // Offset mũi tàu
        Instantiate(bulletPrefab, spawnPos, transform.rotation);
    }
}