﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Repetir : MonoBehaviour
{
    // Start is called before the first frame 
    private float counter = 0;
    private Ganar ganar;
    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 2)
        {
            ganar = GameObject.Find("Canvas").GetComponent<Ganar>();
            ganar.perder();
        }
    }
}
