using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkController : MonoBehaviour
{
    HingeJoint2D hingeJoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            hingeJoint.enabled = false;
        }
    }

    public void Awake()
    {
        hingeJoint = GetComponent<HingeJoint2D>();
    }
}
