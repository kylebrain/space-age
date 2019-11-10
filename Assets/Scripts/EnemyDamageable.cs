using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageable : Damageable
{
    public int health;
    public int maxHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    protected override void DealDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
