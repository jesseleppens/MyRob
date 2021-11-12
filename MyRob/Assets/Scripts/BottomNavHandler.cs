using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomNavHandler : MonoBehaviour
{
    int ButtonToggle = -1;
    public Animator Animator;

    public void OnButtonClick ()
    {

        ButtonToggle *= -1;
        //whenever the button is clicked an animation plas to either open te panel or close the panel
        if (ButtonToggle == 1)
        {
            Animator.Play("ButtonRadial_Start");
        }
        else
        {
            Animator.Play("ButtonRadial_End");
        }
    }
}
