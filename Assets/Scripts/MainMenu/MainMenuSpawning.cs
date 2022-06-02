using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSpawning : MonoBehaviour
{
    public Transform[] enemySpawners;
    public GameObject[] enemies;

    private float spawnCooldown = 2f;

    void FixedUpdate() {
        spawnCooldown = spawnCooldown - Time.fixedDeltaTime;

        if(!(spawnCooldown <= 0)) {
            return;
        }

        spawnCooldown = 2f;

        int randomSpawnerIndex = Random.Range(0, enemySpawners.Length);
        int randomEnemyIndex = Random.Range(0, enemies.Length);

        Instantiate(enemies[randomEnemyIndex], new Vector3(enemySpawners[randomSpawnerIndex].position.x, enemySpawners[randomSpawnerIndex].position.y), Quaternion.identity);
    }
}