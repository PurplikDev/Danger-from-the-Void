using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpellLifetime : MonoBehaviour
{
    public int maxLife = 5;
    public float life = 0;
    void FixedUpdate()
    {
        life += Time.deltaTime;
        if(life >= maxLife)
        {
            Destroy(gameObject);
        }
    }

}
