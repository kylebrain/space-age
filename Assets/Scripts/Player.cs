using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    public PlayerMode mode = PlayerMode.CabinMode;
    public bool onPilot = false;
    public bool onGunner = false;
    public float cabinSpeed = 2000;
    private Rigidbody playerRigidbody;
    private Vector2 cabinMove = Vector2.zero;
    private PlayerInput playerInput;

    private InputActionMap cabinActionMap;
    private InputActionMap pilotActionMap;
    private InputActionMap gunnerActionMap;
    private InputActionMap combatActionMap;


    void Start()
    {
        //Debug.Log("Hello world!");
        playerInput = GetComponent<PlayerInput>();
        playerRigidbody = GetComponent<Rigidbody>();
        cabinActionMap = playerInput.actions.FindActionMap("Cabin");
        pilotActionMap = playerInput.actions.FindActionMap("Pilot");
        gunnerActionMap = playerInput.actions.FindActionMap("Gunner");
        combatActionMap = playerInput.actions.FindActionMap("Combat");

        cabinActionMap.Enable();

        mode = PlayerMode.CabinMode;
    }

    void FixedUpdate()
    {
        playerRigidbody.velocity = new Vector3(cabinMove.x, 0, cabinMove.y) * cabinSpeed * Time.fixedDeltaTime;
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
            cabinMove = Vector2.zero;

            ModeManager.ModeSwitch(this, PlayerMode.PilotMode);
        }

        if (onGunner)
        {
            debugString += "Mode switched to Gunner";
            cabinActionMap.Disable();
            gunnerActionMap.Enable();
            combatActionMap.Enable();
            mode = PlayerMode.GunnerMode;
            cabinMove = Vector2.zero;
            ModeManager.ModeSwitch(this, PlayerMode.GunnerMode);
        }

        //Debug.Log(debugString);
    }

    public void OnMove(InputValue axis)
    {
        //Debug.Log("Moved: " + axis.Get());
        cabinMove = (Vector2)axis.Get();
    }

    /**** Pilot controls ****/
    public void OnSteer(InputValue axis)
    {
        Pilot.Move((Vector2)axis.Get());
    }

    /**** Gunner controls ****/
    public void OnAim(InputValue axis)
    {
        //Debug.Log("Aim: " + axis.Get());
    }

    public void OnShoot()
    {
        //Debug.Log("Shot");
    }

    /**** Combat controls ****/
    public void OnModeSwitch()
    {
        pilotActionMap.Disable();
        gunnerActionMap.Disable();
        combatActionMap.Disable();
        cabinActionMap.Enable();
        mode = PlayerMode.CabinMode;
        //Debug.Log("Mode switched to Cabin");
        ModeManager.ModeSwitch(this, PlayerMode.CabinMode);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PilotCollider")
        {
            onPilot = true;
        }
        else if (other.gameObject.name == "GunnerCollider")
        {
            onGunner = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "PilotCollider")
        {
            onPilot = false;
        }
        else if (other.gameObject.name == "GunnerCollider")
        {
            onGunner = false;
        }
    }
}
