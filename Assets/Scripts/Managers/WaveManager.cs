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
    public int enemyCredits = 5;



    void NewWave() {

        switch(waveNumber) {

            case 1: case 2: case 3:
                int randomSpawnerIndex = Random.Range(1, enemySpawners.Length);
                Instantiate(enemies[0], new Vector3(enemySpawners[randomSpawnerIndex].position.x, enemySpawners[randomSpawnerIndex].position.y), Quaternion.identity);
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
