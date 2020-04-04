using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte2 : MonoBehaviour
{
    public GameObject muerto;
    private GameObject Arma;
    private Transform personaje;
    private Transform Enemy;
    private bool hecho = true;
    // Start is called before the first frame update
    void Start()
    {
        Arma = GameObject.Find("Arma");
        personaje = GameObject.Find("Personaje").GetComponent<Transform>();
        Enemy = GameObject.Find("Enemy").GetComponent<Transform>();
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (hecho)
            {
                Instantiate(muerto, personaje.position, Quaternion.identity);
                Destroy(gameObject);
                if (Arma.transform.IsChildOf(Enemy))
                {
                    Destroy(Arma);
                }
                hecho = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.CompareTag("Explosion"))
        {
            if (hecho)
            {
                Instantiate(muerto, transform.position, Quaternion.identity);
                Destroy(gameObject);
                Destroy(Arma);
                hecho = false;
            }
        }
    }
}
