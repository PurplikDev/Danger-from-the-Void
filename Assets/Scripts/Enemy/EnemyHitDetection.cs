using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitDetection : MonoBehaviour
{

    public EnemyHealth enemyDamage;

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Spell")) {
            Destroy(collider.gameObject);
            enemyDamage.Damage(1);
        }
    }
}
