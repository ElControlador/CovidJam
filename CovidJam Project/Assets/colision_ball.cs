using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 posini;
    public GameObject padre;
    void Start()
    {
        posini = new Vector3(padre.transform.position.x, padre.transform.position.y, padre.transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("tilemap") || collision.gameObject.CompareTag("Kill_Element"))
        {
            padre.SetActive(false);
            padre.transform.position = posini;
            gameObject.transform.position = posini;
            padre.SetActive(true);
            // Destroy(gameObject);
        }
    }
    /*void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("tilemap") || collision.gameObject.CompareTag("Kill_Element"))
        {
            gameObject.SetActive(false);
            gameObject.transform.position = posini;
            gameObject.SetActive(true);
            // Destroy(gameObject);
        }
    }/*
   /* void OnBecameInvisible()
    {
        enabled = false;

        gameObject.transform.position = posini;
        enabled = true;
    }*/
}
