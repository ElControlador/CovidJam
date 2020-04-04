using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    public Vector3 Position;
    public float ffd;
    private Transform punto;
    private LaunchProjectile launchproyectile;
    // Start is called before the first frame update
    void Start()
    {
        launchproyectile = GameObject.Find("Arma").GetComponent<LaunchProjectile>();
        punto = GameObject.Find("Punto").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Position = launchproyectile.direction;
        ffd = Vector3.Angle(punto.position, Position);
        transform.rotation = Quaternion.Euler(0, 0, Vector3.Angle(punto.position, Position));
    }
}
