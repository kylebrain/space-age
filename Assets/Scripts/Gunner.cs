using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunner : MonoBehaviour
{
    public Laser laser;
    public Transform gunPosition;
    static Gunner gunner = null;

    Vector2 input;

    const float fireRate = 5f;
    private float fireTimer = 0;
    private bool isShooting;

    public static void Aim(Vector2 movement)
    {
        gunner.input = movement;
    }

    public static void Shoot(bool shooting)
    {
        gunner.isShooting = shooting;
    }

    private void FixedUpdate()
    {
        if(fireTimer > 0 || isShooting)
        {
            fireTimer += Time.fixedDeltaTime;
        }

        if(fireTimer >= (1 / fireRate))
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
