using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpell : MonoBehaviour
{
    public Rigidbody2D spellRB;

    void Update()
    {
        spellRB.velocity = new Vector2(0, 10);
    }
}
