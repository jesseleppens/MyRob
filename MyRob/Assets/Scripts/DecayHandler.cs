using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecayHandler : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        //has a running timer of one minute. when the timer reaches 0 the stats are reset and then the timer resets as well
        if (StatsTracker.timerTime > 0)
        {
            StatsTracker.timerTime -= Time.fixedDeltaTime;
        }
        else
        {
            StatsTracker.timerTime = 60;
            StatsTracker.water = 0;
            StatsTracker.sport = 0;
            StatsTracker.sleep = 0;
            StatsTracker.food = 0;
            StatsTracker.StatsBubbleUpdate();
        }
    }
}
