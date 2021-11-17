using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.API
{
    [System.Serializable]
    public class userinfo
    {
        //all the variables in the API
        public int calories;
        public int cal_burned;
        public int fats;
        public int carbohydrates;
        public int liters;
        public string day;
    }


    [System.Serializable]
     public class Data
    {
        //a list of all the variables of userinfo
        public List<userinfo> data;
    }

    [System.Serializable]
    public class stappenvars
    {
        public int aantal_stappen;
    }

    [System.Serializable]
    public class StappenData
    {
        //a list of all the variables of userinfo
        public List<stappenvars> data;
    }
}
