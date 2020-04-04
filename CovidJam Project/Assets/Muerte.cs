using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    public GameObject muerto;
    private GameObject Arma;
    private bool hecho=true;
    // Start is called before the first frame update
    void Start()
    {
        Arma = GameObject.Find("Arma");
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
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

    private void OnTriggerEnter2D(Collider2D collision)
    
        {
            if (collision.gameObject.CompareTag("Explosion"))
            {
                if (hecho)
                {
                    Instantiate(muerto, transform.position, Quaternion.identity);
                    Destroy(gameObject);
                    
                    hecho = false;
                }
            }
        }
}
