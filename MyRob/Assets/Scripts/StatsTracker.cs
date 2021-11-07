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
    static Image sleepSprite;
    static Image waterSprite;
    static Image foodSprite;
    static Image sportSprite;
    static Sprite[] spriteArray;

    private void Start()
    {
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 0:

                break;
            case 1:

                break;
            case 2:
                Text overview = GameObject.Find("TotalSleep").GetComponent<Text>();
                overview.text = "TOTAL SLEEP: " + StatsTracker.sleep + " HOURS";
                break;
            case 3:

                break;
            case 4:

                break;
        }     
        sleepSprite = GameObject.Find("Sleep").GetComponent<Image>();
        waterSprite = GameObject.Find("Water").GetComponent<Image>();
        foodSprite = GameObject.Find("Food").GetComponent<Image>();
        sportSprite = GameObject.Find("Sport").GetComponent<Image>();
        spriteArray = Resources.LoadAll<Sprite>("UI/ButtonStates");
        StatsBubbleUpdate();
    }

    public static void StatsBubbleUpdate()
    {
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
    }
}
