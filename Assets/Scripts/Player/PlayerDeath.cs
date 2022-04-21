using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [Header("Scripts")]
    public PlayerManager playerManager;

    [Header("Death Screen")]
    public GameObject deathScreen;

    void Update()
    {
        if(playerManager.health <= 0) {
            deathScreen.SetActive(true);
            Time.timeScale = 0f;
        } 
    }
}
