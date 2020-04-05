using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    public Vector2 XD;
    // Update is called once per frame
    void Update()
    {
        if(Reset.pausado == false)
        {
            //transform.right = Input.mousePosition;

            //var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            //var angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
            //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            //float AngleRad = Mathf.Atan2(Input.mousePosition.y - transform.position.y, Input.mousePosition.x - transform.position.x);
            //float AngleDeg = (180 / Mathf.PI) * AngleRad;
            //this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);

            // convert mouse position into world coordinates
            Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // get direction you want to point at
            Vector2 direction = (mouseScreenPosition - (Vector2)transform.position).normalized;
            XD = -direction;
            // set vector of transform directly
            if (XD.x > 0)
            {
                transform.right = -direction;
            }
        }

    }
}