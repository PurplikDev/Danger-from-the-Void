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
            Debug.Log(shopManager.playerManager.maxVis);
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
            Debug.Log(shopManager.playerManager.visDiscount);
        }
    }

    public void BuyHealth()
    {
        if (shopManager.playerManager.gold >= 100)
        {
            shopManager.playerManager.gold -= 100;
            shopManager.playerManager.visDiscount -= 0.1f;

            shopManager.playerManager.visDiscount = Mathf.Ceil(shopManager.playerManager.visDiscount*10)/10;

            visDiscountPurchases++;
            Debug.Log(shopManager.playerManager.visDiscount);
        }
    }
}
