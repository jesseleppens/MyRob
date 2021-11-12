using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgemeenPopUp : MonoBehaviour
{
   
    bool isActive = false;
    public GameObject Panel;

    public void OnButtonClick()   // script zorgt ervoor dat als op de knop wordt gedrukt er een panel wordt geactiveerd of juist wordt gedeactiveerd
    {

        if (isActive == false)
        {
            Panel.SetActive(true);    // activeren panel
            isActive = true;
        }
        else
        {
            Panel.SetActive(false);   // de activeren panel
            isActive = false;
        }
    }
}
