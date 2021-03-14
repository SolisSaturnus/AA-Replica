using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public static int CurrentLife = MainMenu.StartLife;
    public Text lifeText;



    void Start()
    {
        lifeText.text = ("LIVES: " + CurrentLife.ToString());
    }

}
