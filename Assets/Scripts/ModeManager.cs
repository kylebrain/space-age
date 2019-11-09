using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerMode { CabinMode, PilotMode, GunnerMode };

public class ModeManager : MonoBehaviour
{

    public static void ModeSwitch(Player player, PlayerMode playerMode)
    {
        SpriteRenderer sprite = player.GetComponent<SpriteRenderer>();
        switch (playerMode)
        {
            case PlayerMode.GunnerMode:
                sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0.3f);
                break;
            case PlayerMode.PilotMode:
                sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0.3f);
                break;
            case PlayerMode.CabinMode:
                sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 1.0f);
                break;
            default:
                break;
        }
    }

    void Start()
    {

    }


    void Update()
    {

    }
}
