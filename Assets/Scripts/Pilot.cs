using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilot : MonoBehaviour
{
    static Pilot pilot = null;
    public Camera PilotCamera;
    public GameObject CombatBackground;

    Vector2 input;
    float speed = 10.0f;
    float turningRate = 180.0f;
    float acceleration = 5.0f;
    float maxSpeed = 50.0f;
    float minSpeed = -5.0f;

    public static void Move(Vector2 movement)
    {
        pilot.input = movement;
    }

    void Awake()
    {
        if (pilot == null)
        {
            pilot = this;
            input = new Vector2(0, 0);
        }
        else
        {
            Debug.LogError("Cannot create more than one pilot object because it is a singleton.");
        }
    }

    void FixedUpdate()
    {
        speed += input.y * acceleration * Time.fixedDeltaTime;
        speed = Mathf.Clamp(speed, minSpeed, maxSpeed);
        pilot.transform.position += pilot.transform.up * Time.fixedDeltaTime * speed;
        pilot.transform.Rotate(0, 0, -input.x * turningRate * Time.fixedDeltaTime);
        PilotCamera.transform.position = new Vector3(pilot.transform.position.x, PilotCamera.transform.position.y, pilot.transform.position.z);
        CombatBackground.transform.position = new Vector3(pilot.transform.position.x, CombatBackground.transform.position.y, pilot.transform.position.z);
        float scrollScalar = 500f;
        CombatBackground.GetComponent<MeshRenderer>().material.SetTextureOffset("_MainTex", new Vector2(pilot.transform.position.x, pilot.transform.position.z) / scrollScalar);
    }

}
