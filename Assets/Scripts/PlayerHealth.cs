using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die();  // Nổ + destroy player

        // Disable control
        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<PlayerShooter>().enabled = false;

        Debug.Log("PLAYER DIED - Game Over!");  // Sau add UI panel/restart
    }
}