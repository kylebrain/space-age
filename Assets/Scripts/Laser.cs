using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    const float speed = 200;

    // Start is called before the first frame update
    void Start()
    {
        transform.localEulerAngles += new Vector3(90, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.up * speed * Time.fixedDeltaTime;
    }
}
