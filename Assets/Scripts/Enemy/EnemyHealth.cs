using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public EnemyManager enemyManager;
    public Slider enemyHealthBarSlider;



    public void setHealth(int health)
    { enemyHealthBarSlider.value = health; }
    public void maxHealth(int maxHealth)
    { enemyHealthBarSlider.maxValue = maxHealth; }




    public void Damage(int damage) {
        enemyManager.health -= damage;
        setHealth(enemyManager.health);

        if(enemyManager.health <= 0) {
            Destroy(gameObject);
        }
    }

    void Heal(int heal) {

        if(enemyManager.health >= enemyManager.maxHealth) {
            return;
        } else {
            enemyManager.health += heal;
            setHealth(enemyManager.health);
        }
    }

    void Start()
    {
        maxHealth(enemyManager.maxHealth);
        setHealth(enemyManager.health);
    }
}