using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour
{
    public int catEnd = 0, mouseEnd = 0;
    public void Update()
    {
        catEnd = PlayerPrefs.GetInt("catEnd", catEnd);
        mouseEnd = PlayerPrefs.GetInt("mouseEnd", mouseEnd);
        if((catEnd == 1) & (mouseEnd == 1))
        {
            Debug.Log("Ended");
            PlayerPrefs.SetInt("catEnd", 0);
            PlayerPrefs.SetInt("mouseEnd", 0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
