using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("Health")]
    public int maxHealth;
    public int health;

    [Header("Armor")]
    public int maxArmor;
    public int armor;

    [Header("Vis")]
    public float maxVis;
    public float vis;

    [Header("Movement")]
    public float defaultSpeed;

    
    [Header("Rotating")]
    public float maxRange;
    public float minRange;
}
