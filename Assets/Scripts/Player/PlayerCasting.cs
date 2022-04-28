using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public PlayerManager playerManager;
    public PlayerHealthArmorBar playerVis;

    [Header("Spells")]
    public GameObject projectiveSpell; 

    [Header("Gauntlet")]
    public Transform gauntlet;
    public Transform castingPoint;

    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            SpellCast();
        }
    }

    void SpellCast() {
        if(playerManager.vis > 20) {
            playerManager.vis -= 20;
            playerVis.setVis(playerManager.vis);
            Instantiate(projectiveSpell, castingPoint.position, gauntlet.rotation);
        }
    }
}
