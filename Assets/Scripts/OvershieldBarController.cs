using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OvershieldBarController : MonoBehaviour
{

    public Slider bar1;
    public Slider bar2;
    public Slider bar3;
    public Slider bar4;
    public Slider bar5;

    public float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bar1.value = SubsystemManager.overshieldHealth1;
        bar2.value = SubsystemManager.overshieldHealth2;
        bar3.value = SubsystemManager.overshieldHealth3;
        bar4.value = SubsystemManager.overshieldHealth4;
        bar5.value = SubsystemManager.overshieldHealth5;

        
        time += Time.deltaTime;

        while (time > 1)
        {
            time -= 1;

            if (SubsystemManager.overshieldHealth1 < 20)
            {
                SubsystemManager.overshieldHealth1++;
            }

            else if (SubsystemManager.overshieldHealth2 < 20)
            {
                SubsystemManager.overshieldHealth2++;
            }

            else if (SubsystemManager.overshieldHealth3 < 20)
            {
                SubsystemManager.overshieldHealth3++;
            }

            else if (SubsystemManager.overshieldHealth4 < 20)
            {
                SubsystemManager.overshieldHealth4++;
            }

            else if (SubsystemManager.overshieldHealth5 < 20)
            {
                SubsystemManager.overshieldHealth5++;
            }
        }

        
    }
}
