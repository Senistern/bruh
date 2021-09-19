using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSir : MonoBehaviour
{
    public GameObject Sir;
    public float amount;
    private float sir;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        sir = PlayerPrefs.GetFloat("sir");
        sir += amount;
        PlayerPrefs.SetFloat("sir", sir);
        Destroy(Sir);
    }
}
