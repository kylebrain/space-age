using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class Player : MonoBehaviour
{
    public PlayerMode mode = PlayerMode.CabinMode;
    public bool onPilot = false;
    public bool onGunner = false;
    //public Pilot pilot;
    private PlayerInput playerInput;

    private InputActionMap cabinActionMap;
    private InputActionMap pilotActionMap;
    private InputActionMap gunnerActionMap;
    private InputActionMap combatActionMap;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
        playerInput = GetComponent<PlayerInput>();
        cabinActionMap = playerInput.actions.FindActionMap("Cabin");
        pilotActionMap = playerInput.actions.FindActionMap("Pilot");
        gunnerActionMap = playerInput.actions.FindActionMap("Gunner");
        combatActionMap = playerInput.actions.FindActionMap("Combat");

        cabinActionMap.Enable();

        mode = PlayerMode.CabinMode;
    }

    void FixedUpdate()
    {

    }

    /**** Cabin controls ****/
    public void OnInteract()
    {
        string debugString = "Interacted: ";
        if (onPilot)
        {
            debugString += "Mode switched to Pilot";
            cabinActionMap.Disable();
            pilotActionMap.Enable();
            combatActionMap.Enable();
            mode = PlayerMode.PilotMode;
            ModeManager.ModeSwitch(this, PlayerMode.PilotMode);
        }

        if (onGunner)
        {
            debugString += "Mode switched to Gunner";
            cabinActionMap.Disable();
            gunnerActionMap.Enable();
            combatActionMap.Enable();
            mode = PlayerMode.GunnerMode;
            ModeManager.ModeSwitch(this, PlayerMode.GunnerMode);
        }

        Debug.Log(debugString);
    }

    public void OnMove(InputValue axis)
    {
        Debug.Log("Moved: " + axis.Get());
    }

    /**** Pilot controls ****/
    public void OnSteer(InputValue axis)
    {
        //Debug.Log("Steered: " + axis.Get());
        //Debug.Log("SteeredX: " + ((Vector2)axis.Get()).x);
        //Debug.Log("SteeredY: " + ().y);
        Pilot.Move((Vector2)axis.Get());
    }

    /**** Gunner controls ****/
    public void OnAim(InputValue axis)
    {
        Debug.Log("Aim: " + axis.Get());
    }

    public void OnShoot()
    {
        Debug.Log("Shot");
    }

    /**** Combat controls ****/
    public void OnModeSwitch()
    {
        pilotActionMap.Disable();
        gunnerActionMap.Disable();
        combatActionMap.Disable();
        cabinActionMap.Enable();
        mode = PlayerMode.CabinMode;
        Debug.Log("Mode switched to Cabin");
        ModeManager.ModeSwitch(this, PlayerMode.CabinMode);
    }
}
