using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D enemyRigidbody2D;
    public EnemyManager enemyManager;
    public PlayerManager playerManager;

    void Update()
    {
        if(enemyManager.waveManager.waveActive) {
            enemyRigidbody2D.velocity = new Vector2(0, -1 * enemyManager.defaultEnemySpeed);
        }

        if(playerManager.fortActive == false) {
            
        }
    }
}
