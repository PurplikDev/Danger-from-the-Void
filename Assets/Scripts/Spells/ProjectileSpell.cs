using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpell : MonoBehaviour
{
    public Rigidbody2D spellRB;

    private float lifeTime = 0;

    void Update()
    {
        transform.position += transform.up * Time.deltaTime * 25f;

    }

    void FixedUpdate() {

        lifeTime++;

        if(lifeTime > 50) {
            Destroy(gameObject);
        }

    }
}
