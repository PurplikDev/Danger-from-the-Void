using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopUI : MonoBehaviour
{
    public TextMeshProUGUI shopGoldDisplay;

    public ShopManager shopManager;

    void Update()
    {
        shopGoldDisplay.text = shopManager.playerManager.gold.ToString();
    }
}
