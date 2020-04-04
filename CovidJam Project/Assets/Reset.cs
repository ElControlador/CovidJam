using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private Scene p;
    private int n;
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

    public void Reseteo()
    {
        p = SceneManager.GetActiveScene();

            SceneManager.LoadScene(p.name);
    }

    public void Siguiente()
    {
        p = SceneManager.GetActiveScene();
        n = p.buildIndex;
        SceneManager.LoadScene(n + 1);
    }
}
