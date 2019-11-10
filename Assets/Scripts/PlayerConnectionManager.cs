using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInputManager))]
public class PlayerConnectionManager : MonoBehaviour
{
    public Sprite blueMan;
    public Sprite redMan;

    public GameObject startScreen;

    private bool lastBlueMan = false;

    public void OnPlayerJoined(PlayerInput playerInput)
    {
        startScreen.SetActive(false);
        playerInput.GetComponent<SpriteRenderer>().sprite = lastBlueMan ? redMan : blueMan;
        lastBlueMan = !lastBlueMan;
    }
}
