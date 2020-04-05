using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public Transform ball;
    public Rigidbody2D ball_rigidBody;
    public GameObject dots;
    public static bool is_launched_bplayer;
    private float VELOCITY = 24f;

    private void Awake()
    {
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            is_launched_bplayer = true;
        }

        if (is_launched_bplayer && Reset.pausado == false)
        {
            Launch();
        }
        if(Reset.pausado == true)
        {
            is_launched_bplayer = false;
        }
    }


    private void Launch()
    {
        ball.gameObject.SetActive(true);
        dots.gameObject.SetActive(false);
        ball.transform.Translate(Vector2.right * Time.deltaTime * VELOCITY);
    }
}
