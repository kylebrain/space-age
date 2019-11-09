using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilot : MonoBehaviour
{
    static Pilot pilot = null;

    static Vector2 input;
    static float speed;
    static float turningRate;
    public static void Move(Vector2 movement)
    {
        //pilot.transform.position += new Vector3(0, 0, movement.y) * Time.fixedDeltaTime * 10;
        //Debug.Log(pilot.transform.position);
        input = movement;
        //speed += movement.y;
    }

    void Awake()
    {
        if (pilot == null)
        {
            pilot = this;
            speed = 0.0f;
            turningRate = 0.0f;
        }
        else
        {
            Debug.LogError("Cannot create more than one pilot object because it is a singleton.");
        }
    }

    void FixedUpdate()
    {
        speed += input.y * 0.1f;
        pilot.transform.position += new Vector3(0, 0, speed) * Time.fixedDeltaTime * 10;
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
