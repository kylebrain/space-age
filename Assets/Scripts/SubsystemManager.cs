using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class SubsystemManager
{
    public static int shieldHealth = 100;
    public static int weaponHealth = 100;
    public static int navigationHealth = 100;
    public static int mainHealth = 200;

    // Shield Critical Systems
    public const int fieldGenerator = 0;
    public const int impactRouter = 1;
    public const int shieldBattery = 2;

    public static bool fieldGeneratorDamaged = false;
    public static bool impactRouterDamaged = false;
    public static bool shieldBatteryDamaged = false;

    // Weapons Critical Systems
    public const int protonAccelerator = 3;
    public const int impulseConductor = 4;
    public const int laserCluster = 5;

    public static bool protonAcceleratorDamaged = false;
    public static bool impulseConductorDamaged = false;
    public static bool laserClusterDamaged = false;

    // Navigation Critical Systems
    public const int mainEngines = 6;
    public const int hyperdriveGenerator = 7;
    public const int inertialDampeners = 8;

    public static bool mainEnginesDamaged = false;
    public static bool hyperdriveGeneratorDamaged = false;
    public static bool inertiaDampenersDamaged = false;

    public static void OnHit()
    {
        int criticalChance = (int)((int)9 / .2);
        int roll = Random.Range(0, criticalChance);

        switch (roll)
        {
            case fieldGenerator:
                if (!fieldGeneratorDamaged)
                {
                    fieldGeneratorDamaged = true;
                    shieldHealth -= 20;
                }

                break;

            case impactRouter:
                if (!impactRouterDamaged)
                {
                    impactRouterDamaged = true;
                    shieldHealth -= 20;
                }

                break;

            case shieldBattery:
                if (!shieldBatteryDamaged)
                {
                    shieldBatteryDamaged = true;
                    shieldHealth -= 20;
                }

                break;

            case protonAccelerator:
                if (!protonAcceleratorDamaged)
                {
                    protonAcceleratorDamaged = true;
                    weaponHealth -= 20;
                }

                break;

            case impulseConductor:
                if (!impulseConductorDamaged)
                {
                    impulseConductorDamaged = true;
                    weaponHealth -= 20;
                }

                break;

            case laserCluster:
                if (!laserClusterDamaged)
                {
                    laserClusterDamaged = true;
                    weaponHealth -= 20;
                }

                break;

            case mainEngines:
                if (!mainEnginesDamaged)
                {
                    mainEnginesDamaged = true;
                    navigationHealth -= 20;
                }

                break;

            case hyperdriveGenerator:
                if (!hyperdriveGeneratorDamaged)
                {
                    hyperdriveGeneratorDamaged = true;
                    navigationHealth -= 20;
                }

                break;

            case inertialDampeners:
                if (!inertiaDampenersDamaged)
                {
                    inertiaDampenersDamaged = true;
                    navigationHealth -= 20;
                }

                break;
        }
    }
}
