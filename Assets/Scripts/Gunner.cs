using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunner : MonoBehaviour
{
    AudioSource audioSource;
    public Laser laser;
    public Transform gunPosition;
    static Gunner gunner = null;

    Vector2 input;

    private float fireRate;
    private const float fireRateMax = 6f;
    private float fireTimer = 0;
    private bool isShooting;

    public static void Aim(Vector2 movement)
    {
        gunner.input = movement;
    }

    public static void Shoot(bool shooting)
    {
        //audioSource.Play();
        gunner.isShooting = shooting;
    }

    private void FixedUpdate()
    {
        fireRate = (float)SubsystemManager.weaponHealth / 100.0f * fireRateMax;

        if(SubsystemManager.weaponHealth > 75)
        {
            fireRate = fireRateMax;
        } else if (SubsystemManager.weaponHealth > 50)
        {
            fireRate = 0.75f * fireRateMax;
        } else if(SubsystemManager.weaponHealth > 0)
        {
            fireRate = 0.5f * fireRateMax;
        } else
        {
            fireRate = 0;
            fireTimer = 0;
        }

        if(fireTimer > 0 || isShooting)
        {
            fireTimer += Time.fixedDeltaTime;
        }

        if(fireRate > 0 && fireTimer >= (1 / fireRate))
        {
            if(isShooting)
            {
                Vector3 shotPos;
                if(gunner.input == Vector2.zero)
                {
                    shotPos = transform.up;
                } else
                {
                    shotPos = new Vector3(gunner.input.x, 0, gunner.input.y);
                }
                Instantiate(gunner.laser, gunner.gunPosition.position, Quaternion.LookRotation(shotPos, Vector3.up));
            }
            fireTimer = 0;
        }
    }

    private void Awake()
    {
        // currently a singleton, but can change if there can be more than one gunner
        audioSource = GetComponent<AudioSource>();
        if (gunner == null)
        {
            gunner = this;
            input = new Vector2(0, 0);
        }
        else
        {
            Debug.LogError("Cannot create more than one gunner object because it is a singleton.");
        }
    }

    private void Start()
    {
        fireTimer = fireRate;
    }
}
