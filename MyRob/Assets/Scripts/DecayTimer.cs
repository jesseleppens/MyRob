using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecayTimer : MonoBehaviour
{
    public float timeRemaining = 2;
  
    void Start()
    {
        timeRemaining = 2;

    }


    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            StatsTracker.food -= 50;
            StatsTracker.sport -= 30;
            StatsTracker.water -= 50;
            StatsTracker.sleep -= 1;
            timeRemaining = 2;
            StatsTracker.StatsBubbleUpdate();
        }

        if(StatsTracker.food < 0)
        {
            StatsTracker.food = 0;
        }

        if (StatsTracker.sport < 0)
        {
            StatsTracker.sport = 0;
        }

        if (StatsTracker.water < 0)
        {
            StatsTracker.water = 0;
        }

        if (StatsTracker.sleep < 0)
        {
            StatsTracker.sleep = 0;
        }
    }
}
