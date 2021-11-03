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
