using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkController : MonoBehaviour
{
    HingeJoint2D hingeJoint;
    BoxCollider2D boxCollider2D;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            hingeJoint.enabled = false;
            //StartCoroutine(deshabilitar());
            // boxCollider2D.enabled = false;
        }
    }

    internal void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball") ||
            collision.gameObject.tag.Equals("Explosion"))
        {
            boxCollider2D.isTrigger = false;
            hingeJoint.enabled = false;
            //StartCoroutine(deshabilitar());
            // boxCollider2D.enabled = false;
        }
    }

    private IEnumerator deshabilitar()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }

    public void Awake()
    {
        hingeJoint = GetComponent<HingeJoint2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
}
