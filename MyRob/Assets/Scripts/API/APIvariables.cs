using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.API
{
    [System.Serializable]
    public class userinfo
    {
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
        public List<userinfo> data;
    }
}
