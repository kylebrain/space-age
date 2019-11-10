using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenUpdate : MonoBehaviour
{
    public Text scoreText;


    private void OnEnable()
    {
        scoreText.text = "Score: " + SubsystemManager.score.ToString();
    }
}
