using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    /// <summary>
    /// Imagen de la caja.
    /// </summary>
    internal SpriteRenderer background;
    internal BoxCollider2D collider;
    internal Rigidbody2D rigidbody;
    public GameObject[] woodsBroke;

    internal void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D");
        if (collision.gameObject.tag.Equals("Ball"))
        {
            gameObject.SetActive(false);
            foreach (GameObject g in woodsBroke)
            {
                g.SetActive(true);
            }
        }
    }

    internal void Awake()
    {
        foreach (GameObject g in woodsBroke)
        {
            g.SetActive(false);
        }
        background = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();
        rigidbody = GetComponent<Rigidbody2D>();
    }
}
