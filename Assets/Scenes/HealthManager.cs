using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;
    public int health = 5;
    public TMP_Text healthText;

    private void Awake()
    {
        instance = this;
    }
 
    public void DecreaseHealth()
    {

        if (health > 0)
        {
           health--;
        }
        if(health <= 0)
        {
           print("You are dead!");
        }
        healthText.SetText(health.ToString());

    }

}
