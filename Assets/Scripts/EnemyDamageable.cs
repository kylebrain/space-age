using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageable : Damageable
{
    public int health;
    public int maxHealth = 100;
    private bool destroyed = false;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        health = maxHealth;
    }

    protected override void DealDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            if (destroyed == false)
            {
                if(audioSource != null)
                {
                    audioSource.Play();
                    destroyed = true;
                }
            }

            gameObject.GetComponent<Renderer>().enabled = false;
            Destroy(this);
            Destroy(gameObject, 1.0f);
        }
    }
}
