using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuEnemyMovement : MonoBehaviour
{
    public Rigidbody2D enemyRigidbody2D;

    void Update()
    {
        enemyRigidbody2D.velocity = new Vector2(0, -1);
    }
}
