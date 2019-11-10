using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDamageManager : MonoBehaviour
{
    // user hit detection
    // health bar damage
    // shield bar damage and regeneration
    // system performance manager

    public const int fieldGenerator = 0;
    public const int impactRouter = 1;
    public const int shieldBattery = 2;

    public const int protonAccelerator = 3;
    public const int impulseConductor = 4;
    public const int laserCluster = 5;

    public const int mainEngines = 6;
    public const int hyperdriveGenerator = 7;
    public const int inertialDampeners = 8;

    public const int shieldChance = 0;
    public const int weaponsChance = 1;
    public const int navigationChance = 2;

    public const int criticalChance = 6; //(int)((int)9 / .05);
    public const int criticalDamage = 20;

    public GameObject endScreen;

    private static UserDamageManager instance;

    public int collisionDamage = 10;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else
        {
            Debug.LogError("No more than one UserDamageManager!");
        }
    }

    public static void OnHit(int damageAmount)
    {
        // Regular Damage

        int roll = Random.Range(0, 3);

        switch (roll)
        {
            case shieldChance:
                if (SubsystemManager.shieldHealth - damageAmount > 0)
                {
                    SubsystemManager.shieldHealth -= damageAmount;
                }

                else
                {
                    SubsystemManager.shieldHealth = 0;
                }
                break;

            case weaponsChance:
                if (SubsystemManager.weaponHealth - damageAmount > 0)
                {
                    SubsystemManager.weaponHealth -= damageAmount;
                }

                else
                {
                    SubsystemManager.weaponHealth = 0;
                }
                break;

            case navigationChance:
                if (SubsystemManager.navigationHealth - damageAmount > 0)
                {
                    SubsystemManager.navigationHealth -= damageAmount;
                }

                else
                {
                    SubsystemManager.navigationHealth = 0;
                }
                break;
        }

        if (SubsystemManager.overshieldHealth > 0)
        {
            if (SubsystemManager.overshieldHealth >= damageAmount)
            {
                SubsystemManager.overshieldHealth -= damageAmount;
            }

            else
            {
                int dif = damageAmount - SubsystemManager.overshieldHealth;
                SubsystemManager.overshieldHealth = 0;
                SubsystemManager.mainHealth -= dif;

                if(SubsystemManager.mainHealth <= 0)
                {
                    instance.endScreen.SetActive(true);
                    Time.timeScale = 0;
                }
            }
        }

        else
        {
            SubsystemManager.mainHealth -= damageAmount;
        }

        // Critical Hit System

        roll = Random.Range(0, criticalChance);

        switch (roll)
        {
            case shieldChance:
                if (SubsystemManager.shieldHealth - criticalDamage > 0)
                {
                    SubsystemManager.shieldHealth -= criticalDamage;
                }

                else
                {
                    SubsystemManager.shieldHealth = 0;
                }
                break;

            case weaponsChance:
                if (SubsystemManager.weaponHealth - criticalDamage > 0)
                {
                    SubsystemManager.weaponHealth -= criticalDamage;
                }

                else
                {
                    SubsystemManager.weaponHealth = 0;
                }
                break;

            case navigationChance:
                if (SubsystemManager.navigationHealth - criticalDamage > 0)
                {
                    SubsystemManager.navigationHealth -= criticalDamage;
                }

                else
                {
                    SubsystemManager.navigationHealth = 0;
                }
                break;
        }

        /*switch (roll)
        {
            case fieldGenerator:
                if (!SubsystemManager.fieldGeneratorDamaged)
                {
                    SubsystemManager.fieldGeneratorDamaged = true;
                    SubsystemManager.shieldHealth -= 20;
                }

                break;

            case impactRouter:
                if (!SubsystemManager.impactRouterDamaged)
                {
                    SubsystemManager.impactRouterDamaged = true;
                    SubsystemManager.shieldHealth -= 20;
                }

                break;

            case shieldBattery:
                if (!SubsystemManager.shieldBatteryDamaged)
                {
                    SubsystemManager.shieldBatteryDamaged = true;
                    SubsystemManager.shieldHealth -= 20;
                }

                break;

            case protonAccelerator:
                if (!SubsystemManager.protonAcceleratorDamaged)
                {
                    SubsystemManager.protonAcceleratorDamaged = true;
                    SubsystemManager.weaponHealth -= 20;
                }

                break;

            case impulseConductor:
                if (!SubsystemManager.impulseConductorDamaged)
                {
                    SubsystemManager.impulseConductorDamaged = true;
                    SubsystemManager.weaponHealth -= 20;
                }

                break;

            case laserCluster:
                if (!SubsystemManager.laserClusterDamaged)
                {
                    SubsystemManager.laserClusterDamaged = true;
                    SubsystemManager.weaponHealth -= 20;
                }

                break;

            case mainEngines:
                if (!SubsystemManager.mainEnginesDamaged)
                {
                    SubsystemManager.mainEnginesDamaged = true;
                    SubsystemManager.navigationHealth -= 20;
                }

                break;

            case hyperdriveGenerator:
                if (!SubsystemManager.hyperdriveGeneratorDamaged)
                {
                    SubsystemManager.hyperdriveGeneratorDamaged = true;
                    SubsystemManager.navigationHealth -= 20;
                }

                break;

            case inertialDampeners:
                if (!SubsystemManager.inertiaDampenersDamaged)
                {
                    SubsystemManager.inertiaDampenersDamaged = true;
                    SubsystemManager.navigationHealth -= 20;
                }

                break;
        }*/
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Damageable>() != null)
        {
            OnHit(collisionDamage);
            Destroy(other.gameObject);
        }

    }

    void OnTriggerExit(Collider other)
    {

    }

}
