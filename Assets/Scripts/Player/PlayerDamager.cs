using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamager : MonoBehaviour
{

    public PlayerHealthArmorBar playerDamage;
    private float attackCooldown = 0;

    void OnCollisionEnter2D(Collision2D collider) {
            if (collider.gameObject.CompareTag("Enemy")) {

                playerDamage.Damage(1);
            }
    }

    void OnCollisionStay2D(Collision2D collision) {
        
        if(collision.gameObject.CompareTag("Enemy")) {

            attackCooldown += Time.deltaTime;

            if(attackCooldown >= 1.5) {

                playerDamage.Damage(1);
                attackCooldown = 0;

            }
        }
    }
}
