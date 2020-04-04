using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public GameObject explosion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            gameObject.SetActive(false);
            Instantiate(explosion, transform.position, Quaternion.identity,transform.parent);
        }
    }
}
