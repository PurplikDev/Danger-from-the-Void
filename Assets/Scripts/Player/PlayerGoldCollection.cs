using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerGoldCollection : MonoBehaviour
{
    public PlayerManager playerManager;
    public TextMeshProUGUI playerGoldDisplay;
    public void GiveGold()
    {
        int randomGoldToGive = Random.Range(1, 8);
        playerManager.gold += randomGoldToGive;
    }

    private void Update()
    {
        playerGoldDisplay.text = playerManager.gold.ToString();
    }
}
