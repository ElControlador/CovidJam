using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_ball : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject padre;
    public GameObject pistolero;
    public GameObject posreturn;
    public GameObject sangre;
    public GameObject dots;

    void Start()
    {
        
       // timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
       // timer = timer + Time.deltaTime;
        //if(timer > 0.2)
       // {
         //   timer = 0;
        //}
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("tilemap") || collision.gameObject.CompareTag("Kill_Element") || collision.gameObject.CompareTag("enemigo") || collision.gameObject.CompareTag("Player"))
        {
           // if(timer > 0.1)
            //{
            if(collision.gameObject.CompareTag("enemigo") || collision.gameObject.CompareTag("Player"))
            {
                Instantiate(sangre, gameObject.transform.position, Quaternion.identity);
            }
            padre.SetActive(false);
            padre.transform.position = posreturn.transform.position;
            gameObject.transform.position = posreturn.transform.position;
            if (pistolero.CompareTag("enemigo"))
            {
                Disparar_Enemigo.is_launched_benemigo = false;
            }
            else
            {
                Disparar.is_launched_bplayer = false;
            }
            dots.gameObject.SetActive(true);
                
            //}
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
