using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.API
{
    [System.Serializable]
    public class userinfo
    {
        public int calories;
        public int fats;
    }


    [System.Serializable]
     public class Data
    {
        public List<userinfo> data;
    }
}
