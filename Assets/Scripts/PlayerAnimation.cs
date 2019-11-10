using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    public bool flipped = false;

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void move(Vector2 cabinMove)
    {
        
        if (cabinMove.x < 0 && flipped == false)
        {
            mySpriteRenderer.flipX = true;
            //flipped = true;
        }
        if (cabinMove.x > 0 && flipped == false)
        {
            mySpriteRenderer.flipX = false;
        }
        
    }
}
