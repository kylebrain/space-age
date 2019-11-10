using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Damageable : MonoBehaviour
{
    public int health;
    public bool destroyed = false;
    public int maxHealth = 100;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
                Debug.Log("health " + health);
                if(destroyed == false)
                {
                    audioSource.Play();
                    destroyed = true;
                }
                gameObject.GetComponent<Renderer>().enabled = false;
                Destroy(this);
                Destroy(gameObject, 1.0f);
                Destroy(other.gameObject);
            }
        }
    }
}
