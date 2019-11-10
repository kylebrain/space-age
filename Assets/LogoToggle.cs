using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoToggle : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    float m_Red, m_Blue, m_Green;
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor()
    {
        m_SpriteRenderer.color = Color.blue;
        Debug.Log("HEY");
    }
}
