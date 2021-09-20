using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSausage : MonoBehaviour
{
    public GameObject Kolbasa;
    public float amount;
    private float kolbasa;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        kolbasa = PlayerPrefs.GetFloat("kolbasa");
        kolbasa += amount;
        PlayerPrefs.SetFloat("kolbasa", kolbasa);
        Destroy(Kolbasa);
    }
}
