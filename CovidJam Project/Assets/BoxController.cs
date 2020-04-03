using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    /// <summary>
    /// Imagen de la caja.
    /// </summary>
    SpriteRenderer background;
    BoxCollider2D collider;
    Rigidbody2D rigidbody;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D");
        if (collision.gameObject.tag.Equals("Ball"))
        {
            rigidbody.gravityScale = 0;
            collider.enabled = false;
            background.enabled = false;
        }
    }

    private void Awake()
    {
        background = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();
        rigidbody = GetComponent<Rigidbody2D>();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
