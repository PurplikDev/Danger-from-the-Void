using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealing : MonoBehaviour
{
    public EnemyHealth enemyHealing;
    private float healCooldown = 0;

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("EnemyHealingArea"))
        {

            healCooldown += Time.deltaTime;

            if (healCooldown >= 2)
            {
                enemyHealing.Heal(1);

                healCooldown = 0;
            }
        }
    }
}
