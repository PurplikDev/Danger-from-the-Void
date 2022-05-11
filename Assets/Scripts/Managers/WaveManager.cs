using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveManager : MonoBehaviour
{
    [Header("Wave Number")]
    public int waveNumber;
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
    public int waveCreadits = 50;



    void NewWave() {

        int randomSpawnerIndex = Random.Range(1, enemySpawners.Length);

        switch (waveNumber) {

            case 1: case 2: case 3:
                
                Instantiate(enemies[0], new Vector3(enemySpawners[randomSpawnerIndex].position.x, enemySpawners[randomSpawnerIndex].position.y), Quaternion.identity);
                break;

            case 4: case 5:
                int stageTwoRandomEnemyIndex = Random.Range(0, 1);
                Instantiate(enemies[stageTwoRandomEnemyIndex], new Vector3(enemySpawners[randomSpawnerIndex].position.x, enemySpawners[randomSpawnerIndex].position.y), Quaternion.identity);
                break;

            case 6: case 7: case 8: case 9: case 10:
                int stageThreeRandomEnemyIndex = Random.Range(0, 2);
                Instantiate(enemies[stageThreeRandomEnemyIndex], new Vector3(enemySpawners[randomSpawnerIndex].position.x, enemySpawners[randomSpawnerIndex].position.y), Quaternion.identity);
                break;

            case 11: case 12: case 13: case 14: case 15:
                int stageFourRandomEnemyIndex = Random.Range(0, 3);
                Instantiate(enemies[stageFourRandomEnemyIndex], new Vector3(enemySpawners[randomSpawnerIndex].position.x, enemySpawners[randomSpawnerIndex].position.y), Quaternion.identity);
                break;

            default:
                int stageFiveRandomEnemyIndex = Random.Range(0, 3);
                Instantiate(enemies[stageFiveRandomEnemyIndex], new Vector3(enemySpawners[randomSpawnerIndex].position.x, enemySpawners[randomSpawnerIndex].position.y), Quaternion.identity);
                break;
        }
        waveNumberDisplay.text = waveNumber.ToString();
    }

    void FixedUpdate()
    {
        waveCooldownTimer -= 1 * Time.fixedDeltaTime;
        waveCooldownDisplay.text = Mathf.Ceil(waveCooldownTimer).ToString();
        
        if(waveCooldownTimer <= 0 && waveActive == false)
        {
            waveCooldownTimer = 0;
            waveActive = true;
            waveCooldownPanel.SetActive(false);

            NewWave();
        } else if (waveCooldownTimer > 0 && waveActive == false) {
            waveCooldownPanel.SetActive(true);
        }
    }


}
