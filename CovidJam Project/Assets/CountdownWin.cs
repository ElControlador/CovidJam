using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownWin : MonoBehaviour
{
    // Start is called before the first frame update
    private float counter = 0;
    private Ganar ganar;

    private void Start()
    {
        ganar = GameObject.Find("Canvas").GetComponent<Ganar>();
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 5)
        {
            ganar.ganar();
        }
    }
}
