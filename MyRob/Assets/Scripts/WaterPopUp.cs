using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPopUp : MonoBehaviour
{
   
    bool isActive = false;
    public GameObject Panel;

    public void OnButtonClick()
    {

        if (isActive == false)
        {
            Panel.SetActive(true);
            isActive = true;
        }
        else
        {
            Panel.SetActive(false);
            isActive = false;
        }
    }
}
