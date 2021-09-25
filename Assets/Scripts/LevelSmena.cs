using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSmena : MonoBehaviour
{
    public void l1()
    {
        SceneManager.LoadScene("level1");
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("level1");
        }
    }
}
