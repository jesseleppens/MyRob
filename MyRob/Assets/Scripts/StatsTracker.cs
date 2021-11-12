using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StatsTracker : MonoBehaviour
{
    public static int sleep;
    public static int water;
    public static int food;
    public static int sport;
    public static float timerTime = 60;
    static Image sleepSprite;
    static Image waterSprite;
    static Image foodSprite;
    static Image sportSprite;
    static Sprite[] spriteArray;
    static Animator animator;

    private void Start()
    {
        //gets the save data and also gets the image components of the stat bars. lastly updates those images
        sleep = PlayerPrefs.GetInt("sleep");
        water = PlayerPrefs.GetInt("water");
        food = PlayerPrefs.GetInt("food");
        sport = PlayerPrefs.GetInt("sport");
        sleepSprite = GameObject.Find("Sleep").GetComponent<Image>();
        waterSprite = GameObject.Find("Water").GetComponent<Image>();
        foodSprite = GameObject.Find("Food").GetComponent<Image>();
        sportSprite = GameObject.Find("Sport").GetComponent<Image>();
        spriteArray = Resources.LoadAll<Sprite>("UI/ButtonStates");
        animator = GameObject.Find("Character_image").GetComponent<Animator>();
        TextUpdate();
        StatsBubbleUpdate();
    }

    public static void TextUpdate()
    {
        //changes the on screen text based on what scene is currently loaded
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 0:

                break;
            case 1:

                break;
            case 2:
                Text overviewSleep = GameObject.Find("TotalSleep").GetComponent<Text>();
                overviewSleep.text = "TOTAL SLEEP: " + StatsTracker.sleep + " HOURS";
                break;
            case 3:

                break;
            case 4:
                Text overViewWater = GameObject.Find("waterGedronken").GetComponent<Text>();
                overViewWater.text = StatsTracker.water + " ML";
                break;
        }

    }

    public static void StatsBubbleUpdate()
    {
        //saves the data and updates the spirtes to show how full the stat bar is
        PlayerPrefs.SetInt("sleep", sleep);
        PlayerPrefs.SetInt("water", water);
        PlayerPrefs.SetInt("sport", sport);
        PlayerPrefs.SetInt("food", food);
        TextUpdate();

        //sleep
        if (sleep == 0)
        {
            sleepSprite.sprite = spriteArray[21];
        }
        if (sleep > 1 && sleep <= 3)
        {
            sleepSprite.sprite = spriteArray[20];
        }
        if (sleep > 3 && sleep <= 5)
        {
            sleepSprite.sprite = spriteArray[19];
        }
        if (sleep > 5 && sleep <= 7)
        {
            sleepSprite.sprite = spriteArray[18];
        }
        if (sleep > 7)
        {
            sleepSprite.sprite = spriteArray[17];
        }

        //water

        if (water == 0)
        {
            waterSprite.sprite = spriteArray[6];
        }
        if (water > 0 && water <= 1000)
        {
            waterSprite.sprite = spriteArray[5];
        }
        if (water > 1000 && water <= 1500)
        {
            waterSprite.sprite = spriteArray[4];
        }
        if (water > 1500 && water <= 2000)
        {
            waterSprite.sprite = spriteArray[3];
        }
        if (water > 2500)
        {
            waterSprite.sprite = spriteArray[2];
        }

     
        //food
         if (food == 0)
        {
            foodSprite.sprite = spriteArray[16];
            }
        if (food > 0 && food <= 1000)
        {
            foodSprite.sprite = spriteArray[15];
        }
        if (food > 1000 && food <= 1500)
        {
            foodSprite.sprite = spriteArray[14];
        }
        if (food > 1500 && food <= 2000)
        {
            foodSprite.sprite = spriteArray[13];
        }
        if (food > 2500)
        {
            foodSprite.sprite = spriteArray[12];
        }

        //sport
        if (sport == 0)
        {
            sportSprite.sprite = spriteArray[11];
        }
        if (sport > 0 && sport <= 500)
        {
            sportSprite.sprite = spriteArray[10];
        }
        if (sport > 500 && sport <= 1000)
        {
            sportSprite.sprite = spriteArray[9];
        }
        if (sport > 1000 && sport <= 1500)
        {
            sportSprite.sprite = spriteArray[8];
        }
        if (sport > 1500)
        {
            sportSprite.sprite = spriteArray[7];
        }

        //changes animation based on stat values
        if (food < 100 && sport < 100 && water < 300 && sleep < 2)
        {
            animator.Play("Rob_Fat");
        }
        else if (food < 500 && sport > 1000)
        {
            animator.Play("Rob_Skinny");
        }
        else
        {
            animator.Play("Rob_Idle");
        }
    }
}
