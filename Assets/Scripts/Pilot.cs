using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilot : MonoBehaviour
{
    public static Pilot instance = null;
    public Camera PilotCamera;
    public GameObject CombatBackground;
    public TerrainManager terrainManager;
    public Player player = null;

    Vector2 input;
    public float speed = 30.0f;
    float turningRate = 180.0f;
    float acceleration = 5.0f;
    float maxSpeed = 50.0f;
    float minSpeed = -5.0f;

    public static void Move(Vector2 movement)
    {
        instance.input = movement;
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
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
        if (SubsystemManager.navigationHealth > 75)
        {
            instance.transform.position += instance.transform.up * Time.fixedDeltaTime * speed;
            instance.transform.Rotate(0, 0, -input.x * turningRate * Time.fixedDeltaTime);
        }
        else if (SubsystemManager.navigationHealth > 50)
        {
            instance.transform.position += instance.transform.up * Time.fixedDeltaTime * speed * 0.75f;
            instance.transform.Rotate(0, 0, -input.x * turningRate * Time.fixedDeltaTime * 0.9f);
        }
        else if (SubsystemManager.navigationHealth > 0)
        {
            instance.transform.position += instance.transform.up * Time.fixedDeltaTime * speed * 0.5f;
            instance.transform.Rotate(0, 0, -input.x * turningRate * Time.fixedDeltaTime * 0.75f);
        }

        PilotCamera.transform.position = new Vector3(instance.transform.position.x, PilotCamera.transform.position.y, instance.transform.position.z);
        CombatBackground.transform.position = new Vector3(instance.transform.position.x, CombatBackground.transform.position.y, instance.transform.position.z);
        float scrollScalar = 500f;
        CombatBackground.GetComponent<MeshRenderer>().material.SetTextureOffset("_MainTex", new Vector2(instance.transform.position.x, instance.transform.position.z) / scrollScalar);
    }

}
