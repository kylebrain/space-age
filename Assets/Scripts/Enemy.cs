using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyLaser laser;
    public Transform gunPosition;
    public float speed;
    public float stoppingDistance;
    public float shootingDistance;

    float turnRate;
    float fireRate;
    float fireAccumulator;

    void Start()
    {
        stoppingDistance = 20f;
        shootingDistance = 30f;
        fireRate = 1.2f;
        fireAccumulator = 0.0f;
        turnRate = 90f;
    }

    void FixedUpdate()
    {
        speed = Pilot.instance.speed - 10f;
        if (speed < 2f)
        {
            speed = 2f;
        }
        float angleDiff = Vector3.SignedAngle(transform.up, Pilot.instance.transform.position - transform.position, Vector3.up);
        if (Mathf.Abs(angleDiff) <= turnRate * Time.fixedDeltaTime)
        {
            transform.Rotate(new Vector3(0, angleDiff, 0), Space.World);
        }
        else if (angleDiff > 0)
        {
            transform.Rotate(new Vector3(0, turnRate * Time.fixedDeltaTime, 0), Space.World);
        }
        else
        {
            transform.Rotate(new Vector3(0, -turnRate * Time.fixedDeltaTime, 0), Space.World);
        }


        float dist = Vector3.Distance(transform.position, Pilot.instance.transform.position);
        if (dist > stoppingDistance)
        {
            transform.localPosition += transform.up * speed * Time.fixedDeltaTime;
        }

        if (dist <= shootingDistance)
        {
            fireAccumulator += Time.fixedDeltaTime;
            while (fireAccumulator >= 1f / fireRate)
            {
                fireAccumulator -= 1f / fireRate;
                if (Mathf.Abs(angleDiff) <= 4)
                {
                    EnemyLaser newLaser = Instantiate(laser, gunPosition.position, Quaternion.LookRotation(transform.up, Vector3.up));
                    newLaser.GetComponent<Weapon>().caster = GetComponent<Damageable>();
                }
            }
        }
        else
        {
            fireAccumulator = 0.0f;
        }


    }
}
