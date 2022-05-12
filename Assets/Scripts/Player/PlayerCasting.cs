using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCasting : MonoBehaviour
{
    public PlayerManager playerManager;
    public PlayerHealthArmorBar playerVis;

    [Header("Selected Spell by ID")]
    public int selectedSpellID = 0;

    [Header("Spell Indicator")]
    public GameObject spellIcon;

    [Header("Spells")]
    public GameObject[] projectileSpell; 

    [Header("Gauntlet")]
    public Transform gauntlet;
    public Transform castingPoint;

    private int spellCost = 0;

    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            SpellCast();
        }

        if (Input.GetButtonDown("SwitchSpell")) {
            if(selectedSpellID <= (projectileSpell.Length - 2)){
                selectedSpellID++;
                switch (selectedSpellID)
                {
                    case 1:
                        spellIcon.GetComponent<Image>().color = new Color32(76,255,76,255);
                        break;

                    default: 
                        Debug.Log("dsafsdfsd");
                        break;
                }
            } else {
                selectedSpellID = 0;
                spellIcon.GetComponent<Image>().color = new Color32(180,75,250,255);
            }
        
        }
    }

    void SpellCast() {

        switch(selectedSpellID) {
            case 0: spellCost = 20; break;
            case 1: spellCost = 100; break;
        }

        if(playerManager.vis > spellCost) {
            playerManager.vis -= spellCost * playerManager.visDiscount;
            playerVis.setVis(playerManager.vis);
            Instantiate(projectileSpell[selectedSpellID], castingPoint.position, gauntlet.rotation);
        }
    }
}
