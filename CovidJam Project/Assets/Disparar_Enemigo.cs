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

    private void Awake()
    {
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            is_launched_benemigo = true;
        }

        if (is_launched_benemigo)
        {
            Launch();
        }
    }


    private void Launch()
    {
        ball.gameObject.SetActive(true);
        dots.gameObject.SetActive(false);
        ball.transform.Translate(Vector2.right * Time.deltaTime * VELOCITY);
    }
}
