using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public WaveManager waveManager;

    [Header("Health")]
    public int maxHealth;
    public int health;

    [Header("Movement")]
    public float defaultEnemySpeed;
}
