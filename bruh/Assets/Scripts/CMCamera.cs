using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CMCamera : MonoBehaviour
{
    
    public GameObject Cat;
    public GameObject Mouse;
    double f;
    public float startSize = 5;
    public float startRast = 10;
    public Camera Cam;

    int distance = -10; //я хз что это но пущай будет
    float lift = 1.5f;
    void Update()
    {

        transform.position = new Vector3(0, lift, distance) + (Cat.transform.position + Mouse.transform.position) / 2;
        /*f = Math.Sqrt(Math.Pow(Cat.transform.position.x - Mouse.transform.position.x, 2) + Math.Pow(Cat.transform.position.y - Mouse.transform.position.y, 2)) * startSize / startRast;
        if (f >= startSize)
        {
            Cam.orthographicSize = float.Parse(f.ToString());
        }*/

    }
}
