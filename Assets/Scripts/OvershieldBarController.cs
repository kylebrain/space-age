using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OvershieldBarController : MonoBehaviour
{
    public Slider []barArray = new Slider [5];

    public float time = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int temp = SubsystemManager.overshieldHealth;

        int i = 0;

        // while less than barArray size
        for (i = 0; i < 5; i++)
        {
            if (temp > 20)
            {
                barArray[i].value = 20;
                temp -= 20;
            }

            else
            {
                barArray[i].value = temp;
                temp = 0;
            }
        }

        time += Time.deltaTime;

        while (time > 1)
        {
            time -= 1;

            SubsystemManager.overshieldHealth += 2;
        }
        
    }
}
