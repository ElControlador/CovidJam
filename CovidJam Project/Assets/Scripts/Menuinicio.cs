using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuinicio : MonoBehaviour
{
    // Start is called before the first frame update
    private Scene p;
    private int n;
    public GameObject Botones;
    public GameObject howtoplay;
    public GameObject credits;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Play()
    {
        p = SceneManager.GetActiveScene();
        n = p.buildIndex;
        SceneManager.LoadScene("nivel1");
    }
    
    public void Howtoplay()
    {
        Botones.SetActive (false);
        howtoplay.SetActive(true);
    }

    public void Credits()
    {
        Botones.SetActive(false);
        credits.SetActive(true);
    }

    public void Back()
    {
        Botones.SetActive(true);
        howtoplay.SetActive(false);
        credits.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
