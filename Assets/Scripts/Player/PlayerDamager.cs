using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamager : MonoBehaviour
{

    public PlayerHealthArmorBar playerDamage;

    void OnCollisionEnter2D(Collision2D collider) {
            if (collider.gameObject.CompareTag("Enemy")) {
                playerDamage.Damage(1);
            }
    }
}
