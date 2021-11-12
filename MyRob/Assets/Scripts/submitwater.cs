using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class submitwater : MonoBehaviour
{


    public Toggle kleinG_Toggle;
    public Toggle normaalG_Toggle;
    public Toggle grootG_Toggle;
    public Toggle kanG_Toggle;
    string Watergedronkenstring;
    public Text WatergedronkenText;
  
    int WaterGedronken = 0;




    public void ButtonClick()
    {
        if (kleinG_Toggle.isOn)
        {
            WaterGedronken = WaterGedronken + 250;            // als de eerste toggle is geselecteerd wordt er 250 ml toegevoegd
        }


        if (normaalG_Toggle.isOn)
        {
            WaterGedronken = WaterGedronken + 330;                // als de eerste tweede is geselecteerd wordt er 250 ml toegevoegd
        }


        if (grootG_Toggle.isOn)
        {
            WaterGedronken = WaterGedronken + 500;                // als de derde  toggle is geselecteerd wordt er 250 ml toegevoegd
        }


        if (kanG_Toggle.isOn)
        {
            WaterGedronken = WaterGedronken + 1000;              // als de vierde toggle is geselecteerd wordt er 250 ml toegevoegd
        }

        Watergedronkenstring = WaterGedronken.ToString();
        WatergedronkenText.text = Watergedronkenstring + " ML";     // verandert de text in unity
        StatsTracker.water = WaterGedronken;                        // zorgt dat de statstracker weet wat water is water = waterdronken

        StatsTracker.StatsBubbleUpdate();     // update de statstracker
    }

   

}