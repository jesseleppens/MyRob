using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SleepHandler : MonoBehaviour
{
    bool isActive = false;
    public GameObject panel;
    public Animator animator;
    public Text WakeupTime;
    public Text SleepTime;
    public Text totalTime;
    public Text totalSleep;
    public Toggle AMtoggle;
    public Toggle AMtoggle2;
    float sleepTime = 1;
    float wakeupTime = 1;
    float total;

    public void OnButtonClick()
    {
        //trigger popup animations
        if (isActive == false)
        {
            panel.SetActive(true);
            animator.Play("SleepPopup_Start");
            isActive = true;
        }
        else
        {
            animator.Play("SleepPopup_End");
            ResetPanel();
            isActive = false;           
        }
    }

    public void Submit()
    {
        totalSleep.text = "TOTAL SLEEP: " + total.ToString() + " HOURS";
        OnButtonClick();
    }

    void ResetPanel()
    {
        sleepTime = 1;
        wakeupTime = 1;
        WakeupTime.text = wakeupTime.ToString();
        SleepTime.text = sleepTime.ToString();
        totalTime.text = "TOTAL: 0 HOURS";
    }


    public void BedTimeChanged(float value)
    {
        if (AMtoggle.isOn)
        {
            // set the text next to the slider as the value then calls totaltime
            WakeupTime.text = value.ToString();
            if (value == 12)
            {
                value = 0;
            }
            sleepTime = value;
            TotalTime(sleepTime, wakeupTime);
        }
        else
        {
            // set the text next to the slider as the value, adds 12 to the value then calls totaltime
            WakeupTime.text = value.ToString();
            sleepTime = value + 12;
            TotalTime(sleepTime, wakeupTime);
        }
    }

    public void WakeupTimeChanged(float value)
    {
        if (AMtoggle2.isOn)
        {
            // set the text next to the slider as the value then calls totaltime
            SleepTime.text = value.ToString();
            if (value == 12)
            {
                value = 0;
            }
            wakeupTime = value;
            TotalTime(sleepTime, wakeupTime);
        }
        else
        {
            // set the text next to the slider as the value, adds 12 to the value then calls totaltime
            SleepTime.text = value.ToString();
            wakeupTime = value + 12;
            TotalTime(sleepTime, wakeupTime);
        }
    }

    void TotalTime(float bed, float awake)
    {
        total = 0;
        total = (awake + 24) - bed;
        //checks if the time is for the next day or the same day, then displays the total sleep time
        if (bed <= 12)
        {
            total = total - 24;
            if (total < 0)
            {
                total *= -1;
            }
            totalTime.text = "TOTAL: " + total + " HOURS";
        }
        else
        {
            totalTime.text = "TOTAL: " + total + " HOURS";
        }
    }
}
