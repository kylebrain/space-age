using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public Text scoreText;

    private void Update()
    {
        scoreText.text = SubsystemManager.score.ToString();
    }
}
