using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElasticBedController : MonoBehaviour
{
    private const float FORCE = 2f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
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
