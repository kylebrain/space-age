using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum PlayerMode { CabinMode, PilotMode, GunnerMode };

[RequireComponent(typeof(PlayerInput))]
public class Player : MonoBehaviour
{
    public PlayerMode mode = PlayerMode.CabinMode;
    private PlayerInput playerInput;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
        playerInput = GetComponent<PlayerInput>();

        playerInput.actions.FindActionMap("Cabin").Enable();
        mode = PlayerMode.CabinMode;
    }

    void FixedUpdate()
    {

    }

    /**** Cabin controls ****/
    public void OnInteract()
    {
        const bool onPilot = true;
        if(onPilot)
        {
            playerInput.actions.FindActionMap("Cabin").Disable();
            playerInput.actions.FindActionMap("Pilot").Enable();
            playerInput.actions.FindActionMap("Combat").Enable();
            mode = PlayerMode.PilotMode;
        }
        Debug.Log("Interacted");
    }

    public void OnMove(InputValue axis)
    {
        Debug.Log("Moved: " + axis.Get());
    }

    /**** Pilot controls ****/
    public void OnSteer(InputValue axis)
    {
        Debug.Log("Steered: " + axis.Get());
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
        playerInput.actions.FindActionMap("Pilot").Disable();
        playerInput.actions.FindActionMap("Combat").Disable();
        playerInput.actions.FindActionMap("Cabin").Enable();
        mode = PlayerMode.CabinMode;
        Debug.Log("Mode swtiched");
    }
}
