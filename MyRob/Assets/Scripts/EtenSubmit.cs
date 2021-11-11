using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EtenSubmit : MonoBehaviour 
{ 
    public Toggle bannana_Toggle;
    public Toggle apple_Toggle;
    public Toggle frikandel_Toggle;
    public Toggle fries_Toggle;
    public Toggle advocado_Toggle;
    public Toggle egg_Toggle;
    public Toggle brocoli_Toggle;
    public Toggle aardbei_Toggle;

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
          Vetten = Vetten + 1;
           Calories = Calories + 152;
          Carbohydrates = Carbohydrates + 33;
           }


           if (apple_Toggle.isOn)
          {
          Vetten = Vetten + 1;
            Calories = Calories + 78;
          Carbohydrates = Carbohydrates + 17;
        }


         if (frikandel_Toggle.isOn)
          {
          Vetten = Vetten + 21;
             Calories = Calories + 284;
         Carbohydrates = Carbohydrates + 11;
           }


         if (advocado_Toggle.isOn)
         {
          Vetten = Vetten + 29;
           Calories = Calories + 322;
          Carbohydrates = Carbohydrates + 1;
            }

           if (fries_Toggle.isOn)
           {
          Vetten = Vetten + 16;
             Calories = Calories + 247;
         Carbohydrates = Carbohydrates + 40;
            }

        if (egg_Toggle.isOn)
        {
            Vetten = Vetten + 6;
            Calories = Calories + 80;
            Carbohydrates = Carbohydrates + 0;
        }

        if (brocoli_Toggle.isOn)
        {
            Vetten = Vetten + 1;
            Calories = Calories + 29;
            Carbohydrates = Carbohydrates + 2;
        }

        if (aardbei_Toggle.isOn)
        {
            Vetten = Vetten + 0;
            Calories = Calories + 32;
            Carbohydrates = Carbohydrates + 6;
        }

        VettenGegetenstring = Vetten.ToString();
         VettenGegetenstringText.text = VettenGegetenstring;


        CaloriesGegetenstring = Calories.ToString();
        CaloriesGegetenText.text = CaloriesGegetenstring;
        StatsTracker.food = Calories;

          CarbohydratesGegetenstring = Carbohydrates.ToString();
          CarbohydratesGegetenText.text = CarbohydratesGegetenstring;


        StatsTracker.StatsBubbleUpdate();

    }


}
