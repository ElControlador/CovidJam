﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElasticBedController : MonoBehaviour
{
    private const float FORCE = 3f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("agregar fuerza");
        if (!collision.gameObject.tag.Equals("Elastic_Bed"))
        {
            if (collision != null)
            {
                if (collision.rigidbody != null)
                {
                    collision.rigidbody.velocity = (collision.rigidbody.velocity + Vector2.up) * (collision.rigidbody.mass * FORCE);
                }
            }
        }
    }
}
