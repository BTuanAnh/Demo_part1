using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 5f;  // Tốc độ bay (có thể chỉnh Inspector)

    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;  // Bay lên (Y tăng)
        transform.position = newPosition;
    }
}