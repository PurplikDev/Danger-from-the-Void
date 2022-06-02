using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Purchases : MonoBehaviour
{
    public ShopManager shopManager;

    private int visStoragePurchases = 0;
    private int visDiscountPurchases = 0;
    public void VisStoragePurchase()
    {
        if(shopManager.playerManager.gold >= 50 && visStoragePurchases < 5)
        {
            shopManager.playerManager.gold -= 50;
            shopManager.playerManager.maxVis += 50;
            visStoragePurchases++;
        }
    }

    public void VisDiscountPurchase()
    {
        if (shopManager.playerManager.gold >= 100 && visDiscountPurchases < 5)
        {
            shopManager.playerManager.gold -= 100;
            shopManager.playerManager.visDiscount -= 0.1f;

            shopManager.playerManager.visDiscount = Mathf.Ceil(shopManager.playerManager.visDiscount*10)/10;

            visDiscountPurchases++;
        }
    }

    public void BuyHealth()
    {
        if (shopManager.playerManager.gold >= 100)
        {
            shopManager.playerManager.gold -= 100;
            shopManager.playerManager.playerHealthArmorBar.Heal(1);
        }
    }

    public void BuySpeed()
    {
        if (shopManager.playerManager.gold >= 100)
        {
            shopManager.playerManager.gold -= 100;
            shopManager.playerManager.defaultSpeed += 0.5f;
        }
    }
}
