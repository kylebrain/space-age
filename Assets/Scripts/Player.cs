using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class Player : MonoBehaviour
{

    public float speed = 2;
    public float jumpHeight = 5;
    public float groundedEpisilon = 0.1f;

    bool jumped = false;
    float move = 0;
    float distToGround = 0;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
        GetComponent<PlayerInput>().actions.actionMaps[0].Enable();
        distToGround = GetComponent<Collider>().bounds.extents.y;
    }

    void FixedUpdate()
    {
        if(jumped)
        {
            if(IsGrounded())
            {
                GetComponent<Rigidbody>().velocity += new Vector3(0, jumpHeight, 0);
                Debug.Log("kyle gae");
                Debug.Log("kyle IS gae");
            }
            jumped = false;
        }

        GetComponent<Rigidbody>().velocity += new Vector3(1, 0, 0) * move * speed * Time.fixedDeltaTime;
    }

    public void OnJump()
    {
        Debug.Log("Trying to jump!");
        jumped = true;
    }

    public void OnMove(InputValue axis)
    {
        Debug.Log("Moved: " + axis.Get());
        move = (float)axis.Get();
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, distToGround + groundedEpisilon);
    }
}
