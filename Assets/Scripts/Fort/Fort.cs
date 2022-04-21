using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fort : MonoBehaviour
{

    public PlayerManager playerManager;

    void Update() {
        if(playerManager.armor <= 0) {
            gameObject.SetActive(false);
            playerManager.fortActive = false;
        }
    }

}
