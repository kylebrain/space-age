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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SubsystemManager.overshieldHealth1++;  
    }

    public static void OnHit()
    {
        // Regular Damage
        //SubsystemManager.mainHealth -= 10;

        if (SubsystemManager.overshieldHealth5 != 0)
        {
            SubsystemManager.overshieldHealth5 -= 5;
        }

        else if (SubsystemManager.overshieldHealth4 != 0)
        {
            SubsystemManager.overshieldHealth4 -= 5;
        }

        else if (SubsystemManager.overshieldHealth3 != 0)
        {
            SubsystemManager.overshieldHealth3 -= 5;
        }

        else if (SubsystemManager.overshieldHealth2 != 0)
        {
            SubsystemManager.overshieldHealth2 -= 5;
        }

        else if (SubsystemManager.overshieldHealth1 != 0)
        {
            SubsystemManager.overshieldHealth1 -= 5;
        }

        // Critical Hit System
        int criticalChance = (int)((int)9 / .2);
        int roll = Random.Range(0, criticalChance);

        switch (roll)
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
        }
    }

    void OnTriggerEnter(Collider other)
    {
        OnHit();
        Destroy(other.gameObject);
    }

    void OnTriggerExit(Collider other)
    {

    }
}
