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
    float bedtimeSliderVal = 1;
    float wakeupSliderVal = 1;
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
        StatsTracker.sleep += (int)total;
        StatsTracker.StatsBubbleUpdate();
        totalSleep.text = "TOTAL SLEEP: " + StatsTracker.sleep + " HOURS";
        OnButtonClick();
    }

    void ResetPanel()
    {
        bedtimeSliderVal = 1;
        wakeupSliderVal = 1;
        WakeupTime.text = wakeupSliderVal.ToString();
        SleepTime.text = bedtimeSliderVal.ToString();
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
            bedtimeSliderVal = value;
            TotalTime(bedtimeSliderVal, wakeupSliderVal);
        }
        else
        {
            // set the text next to the slider as the value, adds 12 to the value then calls totaltime
            WakeupTime.text = value.ToString();
            bedtimeSliderVal = value + 12;
            TotalTime(bedtimeSliderVal, wakeupSliderVal);
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
            wakeupSliderVal = value;
            TotalTime(bedtimeSliderVal, wakeupSliderVal);
        }
        else
        {
            // set the text next to the slider as the value, adds 12 to the value then calls totaltime
            SleepTime.text = value.ToString();
            wakeupSliderVal = value + 12;
            TotalTime(bedtimeSliderVal, wakeupSliderVal);
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
