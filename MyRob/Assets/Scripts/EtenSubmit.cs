using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EtenSubmit : MonoBehaviour 
{ 
    public Toggle bannana_Toggle;
    public Toggle apple_Toggle;
    public Toggle frikandel_Toggle;
    public Toggle advocado_Toggle;
    public Toggle fries_Toggle;

    string VettenGegetenstring;
    string CaloriesGegetenstring;
    string CarbohydratesGegetenstring;

    public Text VettenGegetenstringText;
    public Text CaloriesGegetenText;
    public Text CarbohydratesGegetenText;

    int Vetten = 0;
    int Calories = 0;
    int Carbohydrates = 0;
   



    public void ButtonClick()
    {
        
        if (bannana_Toggle.isOn)
        {
            Vetten = Vetten + 0;
            Calories = Calories + 500;
            Carbohydrates = Carbohydrates + 0;
        }


        if (apple_Toggle.isOn)
        {
            Vetten = Vetten + 0;
            Calories = Calories + 0;
            Carbohydrates = Carbohydrates + 0;
        }


        if (frikandel_Toggle.isOn)
        {
            Vetten = Vetten + 0;
            Calories = Calories + 0;
            Carbohydrates = Carbohydrates + 0;
        }


        if (advocado_Toggle.isOn)
        {
            Vetten = Vetten + 0;
            Calories = Calories + 0;
            Carbohydrates = Carbohydrates + 0;
        }

        if (fries_Toggle.isOn)
        {
            Vetten = Vetten + 0;
            Calories = Calories + 0;
            Carbohydrates = Carbohydrates + 0;
        }

        VettenGegetenstring = Vetten.ToString();
        VettenGegetenstringText.text = VettenGegetenstring + " Vetten";
        

        CaloriesGegetenstring = Calories.ToString();
        CaloriesGegetenText.text = CaloriesGegetenstring + " Calories";
        StatsTracker.food = Calories;

        CarbohydratesGegetenstring = Carbohydrates.ToString();
        CarbohydratesGegetenText.text = CarbohydratesGegetenstring + " Carbohydrates";
       

        StatsTracker.StatsBubbleUpdate();
    }



}
