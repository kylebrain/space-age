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
                // shield code
                bar.value = SubsystemManager.shieldHealth;
                break;

            case StatusType.WeaponType:
                // shield code
                bar.value = SubsystemManager.weaponHealth;
                break;

            case StatusType.NavigationType:
                // shield code
                bar.value = SubsystemManager.navigationHealth;
                break;

            case StatusType.HealthType:
                // shield code
                bar.value = SubsystemManager.mainHealth;
                break;
        }

        ChangeHealth();
    }

    void ChangeHealth()
    {
        switch (system)
        {
            case StatusType.ShieldType:
                // shield code
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (SubsystemManager.shieldHealth > 0)
                    {
                        SubsystemManager.shieldHealth--;
                        Debug.Log("minus 1");
                    }
                }

                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (SubsystemManager.shieldHealth < 100)
                    {
                        SubsystemManager.shieldHealth++;
                        Debug.Log("plus 1");
                    }
                }

                break;

            case StatusType.WeaponType:
                // shield code
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (SubsystemManager.weaponHealth > 0)
                    {
                        SubsystemManager.weaponHealth--;
                        Debug.Log("minus 1");
                    }
                }

                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (SubsystemManager.weaponHealth < 100)
                    {
                        SubsystemManager.weaponHealth++;
                        Debug.Log("plus 1");
                    }
                }
                break;

            case StatusType.NavigationType:
                // shield code
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (SubsystemManager.navigationHealth > 0)
                    {
                        SubsystemManager.navigationHealth--;
                        Debug.Log("minus 1");
                    }
                }

                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (SubsystemManager.navigationHealth < 100)
                    {
                        SubsystemManager.navigationHealth++;
                        Debug.Log("plus 1");
                    }
                }
                break;

            case StatusType.HealthType:
                // shield code
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (SubsystemManager.mainHealth > 0)
                    {
                        SubsystemManager.mainHealth--;
                        Debug.Log("minus 1");
                    }
                }

                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (SubsystemManager.mainHealth < 100)
                    {
                        SubsystemManager.mainHealth++;
                        Debug.Log("plus 1");
                    }
                }
                break;
        }
    }


}
