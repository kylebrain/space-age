using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Damageable : MonoBehaviour
{
    public int health;
    public int maxHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        Weapon weapon = other.GetComponent<Weapon>();
        if (weapon != null)
        {
            health -= weapon.damageAmount;
            if(health <= 0)
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }
    }
}
