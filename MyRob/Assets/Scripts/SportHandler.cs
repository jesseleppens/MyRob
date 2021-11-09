using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SportHandler : MonoBehaviour
{
    bool isActive = false;
    public Animator animator;
    public GameObject panel;


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



}
