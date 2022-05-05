using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortDamage : MonoBehaviour
{

    public PlayerHealthArmorBar fortDamage;

    private float attackCooldown = 0;

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Enemy")) {
            fortDamage.Damage(1);
        }
    }

    void OnCollisionStay2D(Collision2D collision) {
        
        if(collision.gameObject.CompareTag("Enemy")) {

            attackCooldown += Time.deltaTime;

            if(attackCooldown >= 1.5) {

                fortDamage.Damage(1);
                attackCooldown = 0;

            }
        }
    }
}
