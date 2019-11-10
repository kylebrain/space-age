using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedHUD : MonoBehaviour
{
	public Slider speedBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		speedBar.value = Pilot.instance.speed;
    }
}
