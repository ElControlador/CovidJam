using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public Transform ball;
    public Rigidbody2D ball_rigidBody;
    private bool is_launched;
    private float VELOCITY = 12f;

    private void Awake()
    {
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            is_launched = true;
        }

        if (is_launched)
        {
            Launch();
        }
    }


    private void Launch()
    {
        ball.gameObject.SetActive(true);
        if (gameObject.CompareTag("enemigo"))
        {
            //ball_rigidBody.velocity = Input.mousePosition.normalized * -VELOCITY;
            ball.transform.Translate(Vector2.right * Time.deltaTime * VELOCITY);
            //is_launched = false;
        }
        else
        {
            //ball_rigidBody.velocity = Input.mousePosition.normalized * VELOCITY;
            ball.transform.Translate(Vector2.right * Time.deltaTime * VELOCITY);
            //is_launched = false;
        }
    }
}
