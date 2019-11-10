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
    private bool started = false;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void OnPlayerJoined(PlayerInput playerInput)
    {
        if(!started)
        {
            startScreen.SetActive(false);
            started = true;
            Time.timeScale = 1;
        }
        
        playerInput.GetComponent<SpriteRenderer>().sprite = lastBlueMan ? redMan : blueMan;
        lastBlueMan = !lastBlueMan;
    }
}
