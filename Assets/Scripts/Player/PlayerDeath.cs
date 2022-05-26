using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDeath : MonoBehaviour
{
    [Header("Scripts")]
    public PlayerManager playerManager;

    [Header("Death Screen")]
    public GameObject deathScreen;

    [Header("Nadávky")]
    public string[] deathInsults;

    public TextMeshProUGUI deathMessage;

    public bool isStillAlive;

    void Start() {
        isStillAlive = true;
    }

    void Update()
    {
        if(playerManager.health <= 0 && isStillAlive) {

            int randomDeathMessage = Random.Range(0, deathInsults.Length);

            isStillAlive = false;

            deathMessage.text = deathInsults[randomDeathMessage];
            deathScreen.SetActive(true);
            Time.timeScale = 0f;
        } 
    }
}
