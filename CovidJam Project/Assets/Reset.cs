using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private Scene p;
    // Start is called before the first frame update
    void Start()
    {
        p = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(p.name);
        }
    }
}
