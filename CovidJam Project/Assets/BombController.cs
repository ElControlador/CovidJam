using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public GameObject explosion;

    SpriteRenderer spriteRenderer;
    Rigidbody2D rigidbody2D;
    BoxCollider2D collider2D;
    public CameraController camera;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            spriteRenderer.enabled = false;
            collider2D.isTrigger = true;
            Instantiate(explosion, transform.position, Quaternion.identity, transform.parent);
            StartCoroutine(camera.shakeCamera(.15f, .4f));
        }
    }

    //private void (Collider2D collision)
    //{
    //    if (collision.gameObject.tag.Equals("Ball"))
    //    {
    //        spriteRenderer.enabled = false;
    //        Instantiate(explosion, transform.position, Quaternion.identity,transform.parent);
    //        StartCoroutine(camera.shakeCamera(.15f,.4f));
    //    }
    //}        

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider2D = GetComponent<BoxCollider2D>();
    }
}
