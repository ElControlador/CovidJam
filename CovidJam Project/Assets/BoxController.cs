using System;
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
    public GameObject explosion;

    internal void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            background.enabled = false;
            collider.enabled = false;
            Instantiate(explosion, transform.position, Quaternion.identity, transform.parent);
            foreach (GameObject g in woodsBroke)
            {
                g.SetActive(true);
            }
            //StartCoroutine(deshabilitar());
        }
    }

    internal void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Explosion"))
        {            
            background.enabled = false;
            collider.enabled = false;
            Instantiate(explosion, transform.position, Quaternion.identity, transform.parent);
            foreach (GameObject g in woodsBroke)
            {
                g.SetActive(true);
            }
            //StartCoroutine(deshabilitar());
        }
    }

    private IEnumerator deshabilitar()
    {
        yield return new WaitForSeconds(1f);
        transform.parent.gameObject.SetActive(false);
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
