using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidPointer : MonoBehaviour
{ 
    Vector3 Mouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position =new Vector3(Mouse.x,Mouse.y,0);
        if (Reset.pausado == true)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
