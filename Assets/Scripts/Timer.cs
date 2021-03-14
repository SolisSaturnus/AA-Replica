using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public Text timeText;


    void Start()
    {
        timeRemaining = PlayerPrefs.GetFloat("timer");

       
        timeText.text = "time remaining: " + timeRemaining.ToString("F2");
    }
   
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            timeText.text = "time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}