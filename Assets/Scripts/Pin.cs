using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour
{
   

    private bool isPinned = false;

    public float speed;
    public Rigidbody2D rb;
   


    private void Start()
    {
        float newSpeed = PlayerPrefs.GetFloat("pinSpeed");
        speed = newSpeed;
    }

   private void Update()
    {
        if (!isPinned)
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);

       else if (Lives.CurrentLife <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
        }





        else if (col.tag == "Pin")
        {
            Lives.CurrentLife = Lives.CurrentLife - 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            /*Debug.Log("End Game");
            FindObjectOfType<GameManager>().EndGame();*/
        }

    } 
}
