using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LaunchProjectile : MonoBehaviour
{
    #region Constantes
    /// <summary>
    /// Numero de puntos a dibujar...
    /// </summary>
    private const int NUM_DOTS_TO_SHOW = 10;
    /// <summary>
    /// Factor de opacidad
    /// </summary>
    private const float OPACITY_FACTOR = 1f / NUM_DOTS_TO_SHOW;
    /// <summary>
    /// Cada cuanto tiempo se va a dibujar el punto ...
    /// </summary>
    private const float DOT_TIME_STEP = .1f;
    /// <summary>
    /// Velocidad maxima.
    /// </summary>
    private float VELOCITY = 8f;
    #endregion

    #region Variables Privadas
    /// <summary>
    /// Velocidad de lanzamiento del proyectil
    /// </summary>
    private Vector3 launch_velocity;
    /// <summary>
    /// Posicion inicial del proyectil
    /// </summary>
    private Vector3 initial_position = Vector2.zero;
    /// <summary>
    /// Fuerza de gravedad
    /// </summary>
    private Vector3 gravity;
    /// <summary>
    /// Para indicar si cuando se lanza
    /// </summary>
    private bool is_launched = false;
    /// <summary>
    /// Cuerpo rigido del proyectil
    /// </summary>
    private Rigidbody2D ball_rigidBody;
    /// <summary>
    /// Para indicar si se tiene el mouse pulsado o no
    /// </summary>
    private bool is_mouse_down = false;
    /// <summary>
    /// Posicion inicial del puntero cuando se pulsa
    /// </summary>
    private Vector3 initial_mouse_pointer;
    /// <summary>
    /// Lista de elementos para la prediccion del proyectil.
    /// </summary>
    List<GameObject> dots = new List<GameObject>();
    #endregion

    #region Variables publicas
    /// <summary>
    /// Proyectil que se va a lanzar
    /// </summary>
    public Transform ball;
    /// <summary>
    /// Radio de accion para preparar el proyectil
    /// </summary>
    public GameObject action_ratio;
    /// <summary>
    /// Punto que se dibujara en la prediccion de la trayectoria
    /// </summary>
    public GameObject dot;
    /// <summary>
    /// Donde se almacenara los puntos de la traywctoria
    /// </summary>
    public GameObject dots_parent;
    /// <summary>
    /// direccion
    /// </summary>
    public Vector3 direction;

    #endregion


    private void Awake()
    {
        ball_rigidBody = ball.GetComponent<Rigidbody2D>();
        initial_position = ball.position;
        gravity = Vector2.zero;
        //gravity = new Vector2(0f, -ball_rigidBody.gravityScale * 9.81f);
        dots_parent.SetActive(false);
        float initial_opacity = 1;
        for (int i = 0; i < NUM_DOTS_TO_SHOW; i++)
        {
            GameObject trajectoryDot = Instantiate(dot);
            Dot dot_controler = trajectoryDot.GetComponent<Dot>();
            if(dot_controler != null)
            {
                dot_controler.setOpacity(initial_opacity);
                initial_opacity -= OPACITY_FACTOR;
            }
            trajectoryDot.transform.parent = dots_parent.transform;            
            dots.Add(trajectoryDot);
        }

    }

    private void Update()
    {
        if (!is_launched)
        {
            if (initial_position != ball.position)
            {
                initial_position = ball.position;
            }
        }

        if(ball_rigidBody.velocity == Vector2.zero)
        {
            if (ball.gameObject.activeSelf)
            {
                ball.gameObject.SetActive(false);
                ball.position = initial_position;
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (CheckPointerIsInRatio(Input.mousePosition))
                {
                    if (!is_mouse_down)
                    {
                        initial_mouse_pointer = Input.mousePosition;
                        is_mouse_down = true;
                        dots_parent.SetActive(true);
                    }
                }    
            }

            if (Input.GetMouseButtonUp(0))
            {
                is_mouse_down = false;
                is_launched = true;
                dots_parent.SetActive(false);
            }

            if (is_mouse_down)
            {
                direction = (initial_mouse_pointer - Input.mousePosition).normalized;
                launch_velocity = direction * VELOCITY;                

                Debug.Log(direction);
            }

            if (is_launched)
            {
                Launch();
            }

        }
    }

    private bool CheckPointerIsInRatio(Vector3 mousePosition)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

        if (hit.collider != null &&
            hit.collider.transform.tag == action_ratio.tag)
        {
            return true;
        }

        return false;
    }

    private void DrawTrajectory()
    {
        for (int i = 0; i < NUM_DOTS_TO_SHOW; i++)
        {
            GameObject trajectoryDot = dots[i];
            trajectoryDot.transform.position = CalculatePosition(DOT_TIME_STEP * i);
        }
    }

    private void Launch()
    {
        ball.gameObject.SetActive(true);
        if (gameObject.CompareTag("enemigo"))
        {
            ball_rigidBody.velocity = new Vector2(-launch_velocity.x, launch_velocity.y);
            is_launched = false;
        }
        else
        {
            ball_rigidBody.velocity = launch_velocity;
            is_launched = false;
        }
    }

    private Vector2 CalculatePosition(float elapsedTime)
    {
        return gravity * elapsedTime * elapsedTime * 0.5f +
                   ((gameObject.CompareTag("enemigo")) ? (new Vector3(launch_velocity.x * -1, launch_velocity.y)) : launch_velocity) * elapsedTime + initial_position;
    }
}
