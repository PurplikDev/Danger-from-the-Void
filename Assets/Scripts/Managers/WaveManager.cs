using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveManager : MonoBehaviour
{
    [Header("Wave Number")]
    public int waveNumber = 1;
    public TextMeshProUGUI waveNumberDisplay;

    [Header("Wave Cooldown")]
    public bool waveActive;
    float waveCooldownTimer = 5f;
    public TextMeshProUGUI waveCooldownDisplay;
    public GameObject waveCooldownPanel;

    [Header("Spawners and Enemies")]
    public Transform[] enemySpawners;
    public GameObject[] enemies;

    [Header("Spawning Credits")]
    public int waveCredits = 50;

    private float spawnCooldown = 2f;

    public int enemyAmount = 0;

    void NewWave() {
        waveNumberDisplay.text = waveNumber.ToString();
        waveActive = true;
        enemyAmount = 0;
        waveCredits = 2;
    }

    void FixedUpdate()
    {
        waveCooldownTimer -= 1 * Time.fixedDeltaTime;
        waveCooldownDisplay.text = Mathf.Ceil(waveCooldownTimer).ToString();



        if (waveCooldownTimer <= 0 && waveActive == false)
        {
            waveCooldownTimer = 0;
            waveCooldownPanel.SetActive(false);

            NewWave();

        } else if (waveCooldownTimer > 0 && waveActive == false) {
            waveCooldownPanel.SetActive(true);
        }



        while (waveActive && waveCredits > 0)
        {
            spawnCooldown = spawnCooldown - Time.fixedDeltaTime;

            if(!(spawnCooldown <= 0)) {
                return;
            }

            spawnCooldown = 2f;

            int randomSpawnerIndex = Random.Range(1, enemySpawners.Length);

            int randomSpawnsIndex = Random.Range(1, 2);

            for (int i = 0; i < randomSpawnsIndex; i++) {
                switch (waveNumber)
                {

                    case 1:
                    case 2:
                    case 3:

                        Instantiate(enemies[0], new Vector3(enemySpawners[randomSpawnerIndex].position.x, enemySpawners[randomSpawnerIndex].position.y), Quaternion.identity);
                        waveCredits = PayForEnemies(0, waveCredits);
                        break;

                    case 4:
                    case 5:
                        int stageTwoRandomEnemyIndex = Random.Range(0, 1);
                        Instantiate(enemies[stageTwoRandomEnemyIndex], new Vector3(enemySpawners[randomSpawnerIndex].position.x, enemySpawners[randomSpawnerIndex].position.y), Quaternion.identity);
                        waveCredits = PayForEnemies(stageTwoRandomEnemyIndex, waveCredits);
                        break;

                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        int stageThreeRandomEnemyIndex = Random.Range(0, 2);
                        Instantiate(enemies[stageThreeRandomEnemyIndex], new Vector3(enemySpawners[randomSpawnerIndex].position.x, enemySpawners[randomSpawnerIndex].position.y), Quaternion.identity);
                        waveCredits = PayForEnemies(stageThreeRandomEnemyIndex, waveCredits);
                        break;

                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                        int stageFourRandomEnemyIndex = Random.Range(0, 3);
                        Instantiate(enemies[stageFourRandomEnemyIndex], new Vector3(enemySpawners[randomSpawnerIndex].position.x, enemySpawners[randomSpawnerIndex].position.y), Quaternion.identity);
                        waveCredits = PayForEnemies(stageFourRandomEnemyIndex, waveCredits);
                        break;

                    default:
                        int stageFiveRandomEnemyIndex = Random.Range(0, 4);
                        Instantiate(enemies[stageFiveRandomEnemyIndex], new Vector3(enemySpawners[randomSpawnerIndex].position.x, enemySpawners[randomSpawnerIndex].position.y), Quaternion.identity);
                        waveCredits = PayForEnemies(stageFiveRandomEnemyIndex, waveCredits);
                        break;
                }
            }
            enemyAmount++;
            Debug.Log(enemyAmount);
        }

        if (enemyAmount == 0 && waveActive == true)
        {
            waveActive = false;

            waveCooldownTimer = 5;

            waveNumber++;
        }

    }

    int PayForEnemies(int enemyIndex, int credits) {
        switch(enemyIndex) {
            case 0:
                credits = credits - 1;
                break;

            case 1:
                credits = credits - 2;
                break;

            case 2:
                credits = credits - 5;
                break;

            case 3:
                credits = credits - 10;
                break;
        }

        Debug.Log(credits);

        return credits;
    }

}
