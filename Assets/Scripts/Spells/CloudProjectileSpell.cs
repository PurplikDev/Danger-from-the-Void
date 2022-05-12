using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudProjectileSpell : MonoBehaviour
{
    public Rigidbody2D spellRB;

    public GameObject cloudSpell;

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

        void OnTriggerEnter2D(Collider2D collider) {
            if(collider.gameObject.CompareTag("Enemy") || collider.gameObject.CompareTag("HealingEnemy")) {

                Instantiate(cloudSpell, transform.position, transform.rotation);

                Destroy(gameObject);
            
        }
    }
}
