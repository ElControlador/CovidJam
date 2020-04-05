using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private Scene p;
    private int n;
    public GameObject Pause;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.R))
        {
            p = SceneManager.GetActiveScene();
            SceneManager.LoadScene(p.name);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
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
    public void pausa()
    {
        Time.timeScale = 0f;
        Pause.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void resume()
    {
        Time.timeScale = 1f;
        Pause.SetActive(false);
    }
}
