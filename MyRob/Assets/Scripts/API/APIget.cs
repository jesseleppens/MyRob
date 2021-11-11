using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System;
using System.IO;
using Assets.Scripts.API;

public class APIget : MonoBehaviour
{

    public Data GetWeather()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://i480028.hera.fhict.nl/api/?user_id=1");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        Data info = JsonUtility.FromJson<Data>(fixJson(jsonResponse));
        return info;
    }

    string fixJson(string value)
    {
        value = "{\"data\":" + value + "}";
        return value;
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (userinfo item in GetWeather().data)
        {
            Debug.Log(item.fats);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
