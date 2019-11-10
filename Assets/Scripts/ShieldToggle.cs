using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldToggle : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    float m_Red, m_Blue, m_Green;
    BoxCollider boxCollide;
    Color32 transparent = new Color32(59, 237, 245, 130);
    Color32 bright = new Color32(59, 237, 245, 255);

    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        boxCollide = GetComponent<BoxCollider>();
        m_SpriteRenderer.color = transparent;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        m_SpriteRenderer.color = bright;
    }

    void OnTriggerExit(Collider collision)
    {
        m_SpriteRenderer.color = transparent;
    }
}
