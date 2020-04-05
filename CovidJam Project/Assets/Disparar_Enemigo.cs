using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar_Enemigo : MonoBehaviour
{
    public Transform ball;
    public Rigidbody2D ball_rigidBody;
    public GameObject dots;
    public static bool is_launched_benemigo;
    private float VELOCITY = 24f;
    //private float timer;
    private void Start()
    {
        Time.timeScale = 1f;
        /*timer = 0;
        while(timer <= 1)
        {
           timer = timer + Time.deltaTime;
        }*/
    }

    private void Update()
    {
      
            if (Input.GetMouseButtonUp(0))
            {
                is_launched_benemigo = true;
            }

            if (is_launched_benemigo && Reset.pausado == false)
            {
                Launch();
            }
            if (Reset.pausado == true)
            {
                is_launched_benemigo = false;
            }
        
    }


    private void Launch()
    {
        ball.gameObject.SetActive(true);
        dots.gameObject.SetActive(false);
        ball.transform.Translate(Vector2.right * Time.deltaTime * VELOCITY);
    }
}
