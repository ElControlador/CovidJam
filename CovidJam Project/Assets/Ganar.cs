using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar : MonoBehaviour
{
    public GameObject MenuVictoria;
    // Update is called once per frame
   public void ganar()
    {
        MenuVictoria.SetActive(true);
    }
}
