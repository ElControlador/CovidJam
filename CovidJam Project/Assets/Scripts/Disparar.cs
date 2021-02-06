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
    private float counter=0;

    private void Awake()
    {
        counter = 1;
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            is_launched_bplayer = true;
        }

        if (is_launched_bplayer && Reset.pausado == false && counter <= 0)
        {
            Launch();
        }
        if(Reset.pausado == true)
        {
            is_launched_bplayer = false;
            counter = 1;
        }

        if (counter > 0 && Reset.pausado==false)
        {
            counter = counter - Time.deltaTime;
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
