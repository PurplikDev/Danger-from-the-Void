using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthArmorBar : MonoBehaviour
{
    public PlayerManager playerManager;
    public Slider healthBarSlider;
    public Slider armorBarSlider;
    public Slider visBarSlider;



    public void setHealth(int health)
    { healthBarSlider.value = health; }
    public void maxHealth(int maxHealth)
    { healthBarSlider.maxValue = maxHealth; }

    public void setArmor(int armor)
    { armorBarSlider.value = armor; }
    public void maxArmor(int maxArmor)
    { armorBarSlider.maxValue = maxArmor; }

    public void setVis(float vis)
    { visBarSlider.value = vis; }
    public void maxVis(float maxVis)
    { visBarSlider.maxValue = maxVis; }



    public void Damage(int damage) {

        if(playerManager.armor <= 0) {
            playerManager.health -= damage;
            setHealth(playerManager.health);
        } else {
            playerManager.armor -= damage;
            setArmor(playerManager.armor);
        }
    }

    public void Heal(int heal) {

        if(playerManager.health >= playerManager.maxHealth) {
            return;
        } else {
            playerManager.health += heal;
            setHealth(playerManager.health);
        }
    }



    void Start()
    {
        maxHealth(playerManager.maxHealth);
        setHealth(playerManager.health);
        maxArmor(playerManager.maxArmor);
        setArmor(playerManager.armor);
        maxVis(playerManager.maxVis);
        setVis(playerManager.vis);
    }

    void FixedUpdate()
    {
        if (playerManager.vis < playerManager.maxVis) {
            playerManager.vis += 25 * Time.deltaTime;
            setVis(playerManager.vis);
        }
    }
}
