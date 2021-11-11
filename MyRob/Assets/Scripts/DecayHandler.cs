using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecayHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (StatsTracker.timerTime > 0)
        {
            StatsTracker.timerTime -= Time.fixedDeltaTime;
        }
        else
        {
            StatsTracker.timerTime = 10;
            StatsTracker.water = 0;
            StatsTracker.sport = 0;
            StatsTracker.sleep = 0;
            StatsTracker.food = 0;
            StatsTracker.StatsBubbleUpdate();
        }
    }
}
