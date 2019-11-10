using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OvershieldBarController : MonoBehaviour
{
    public Slider[] barArray = new Slider[5];

    public float time = 0;

    public int overshieldIncrement = 10;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int temp = SubsystemManager.overshieldHealth;

        int activeOvershields = GetActiveOvershieldCount();



        int i = 0;

        // while less than barArray size
        for (i = 0; i < activeOvershields; i++)
        {
            if (temp > overshieldIncrement)
            {
                barArray[i].value = overshieldIncrement;
                temp -= overshieldIncrement;
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

    public int GetActiveOvershieldCount()
    {
        if (SubsystemManager.shieldHealth >= 80)
        {
            return 5;
        }

        else if (SubsystemManager.shieldHealth >= 60)
        {
            barArray[4].value = 0;
            //SubsystemManager.overshieldHealth = (int)(.8 * SubsystemManager.maxOvershield);
            return 4;
        }

        else if (SubsystemManager.shieldHealth >= 40)
        {
            barArray[4].value = 0;
            barArray[3].value = 0;
            return 3;
        }

        else if (SubsystemManager.shieldHealth >= 20)
        {
            barArray[4].value = 0;
            barArray[3].value = 0;
            barArray[2].value = 0;
            return 2;
        }

        else if (SubsystemManager.shieldHealth > 0)
        {
            barArray[4].value = 0;
            barArray[3].value = 0;
            barArray[2].value = 0;
            barArray[1].value = 0;
            return 1;
        }

        else
        {
            //Debug.Log("0");
            barArray[4].value = 0;
            barArray[3].value = 0;
            barArray[2].value = 0;
            barArray[1].value = 0;
            barArray[0].value = 0;
            return 0;
        }
    }
}
