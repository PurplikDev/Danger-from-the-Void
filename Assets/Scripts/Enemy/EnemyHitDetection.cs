using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitDetection : MonoBehaviour
{

    public EnemyHealth enemyDamage;
    private float attackCooldown = 0;

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("ProjectileSpell")) {
            Destroy(collider.gameObject);
            enemyDamage.Damage(1);
        }
    }

    void OnTriggerStay2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("CloudSpell")) {

            attackCooldown += Time.deltaTime;

            Debug.Log(attackCooldown);

            if(attackCooldown >= 0.5) {
                enemyDamage.Damage(1);

                attackCooldown = 0;
            }
        }
    }
}