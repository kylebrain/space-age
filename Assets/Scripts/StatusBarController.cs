using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum StatusType { ShieldType, WeaponType, NavigationType, HealthType };

public class StatusBarController : MonoBehaviour
{
    public StatusType system;

    public Slider bar;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        switch (system)
        {
            case StatusType.ShieldType:
                bar.value = SubsystemManager.shieldHealth;
                break;

            case StatusType.WeaponType:
                bar.value = SubsystemManager.weaponHealth;
                break;

            case StatusType.NavigationType:
                bar.value = SubsystemManager.navigationHealth;
                break;

            case StatusType.HealthType:
                bar.value = SubsystemManager.mainHealth;
                break;
        }
    }

    
}
