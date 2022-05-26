using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOpener : MonoBehaviour
{
    public GameObject shop;
    public ShopManager shopManager;
    public void ExitShop()
    {
        shop.SetActive(false);
        shopManager.shopActive = false;
    }

    public void EnterShop()
    {
        shop.SetActive(true);
        shopManager.shopActive = true;
    }
}
