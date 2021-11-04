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

    void Start()
    {
        Debug.Log(kleinG_Toggle);
        Debug.Log(normaalG_Toggle);
        Debug.Log(grootG_Toggle);
        Debug.Log(kanG_Toggle);



    }



    public void ButtonClick()
    {
        if (kleinG_Toggle.isOn)
        {
            WaterGedronken = WaterGedronken + 250;
        }


        if (normaalG_Toggle.isOn)
        {
            WaterGedronken = WaterGedronken + 330;
        }


        if (grootG_Toggle.isOn)
        {
            WaterGedronken = WaterGedronken + 500;
        }


        if (kanG_Toggle.isOn)
        {
            WaterGedronken = WaterGedronken + 1000;
        }

    }
    void Update()
    {
        Watergedronkenstring = WaterGedronken.ToString();
        WatergedronkenText.text = Watergedronkenstring + " ML";
        
    }
}