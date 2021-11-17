using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.API;

public class SportHandler : MonoBehaviour
{
    bool isActive = false;
    public Animator animator;
    public GameObject panel;
    public InputField[] minutesArray;
    public Text totalCaloriesText;
    float[] caloriesArray = {8.1F, 14.9F, 7.9F, 6.5F, 9.4F, 1.6F, 2.6F, 2.2F, 2.0F};
    int totalCalorie;

    public void OnButtonClick()
    {
        //trigger popup animations
        if (isActive == false)
        {
            panel.SetActive(true);
            animator.Play("SportPopup_Start");
            isActive = true;
        }
        else
        {
            animator.Play("SportPopup_End");
            isActive = false;
        }
    }
    public void CalorieCalculate()
    {
        //gets the calories burned per minute from an array then multiplies this by the given workout time, lastly saves this in a static variable and updates the UI
        for (int i = 0; i < minutesArray.Length; i++)
        {
            if (minutesArray[i].text == "" )
            {
                continue;
            }
            totalCalorie += Mathf.RoundToInt(caloriesArray[i] * System.Convert.ToInt32(minutesArray[i].text));
        }
        StatsTracker.sport += totalCalorie;
        APIget.UpdateDatabase();
        StatsTracker.StatsBubbleUpdate();
        totalCalorie = 0;
    }
}
